import scrapy
import os
from scrapy.http import HtmlResponse

ALVAO_VERSION = '11.2'


class AlvaoapispiderSpider(scrapy.Spider):
    name = "AlvaoApiSpider"
    allowed_domains = ["doc.alvao.com"]
    _ver: str = ALVAO_VERSION.replace('.', '_')
    base_url = f'https://doc.alvao.com/en/alvao_{_ver}/alvao_api/html'
    start_urls = [f'{base_url}/N_Alvao_API_AI.htm']

    namespaces = [
        # 'Alvao.API.AI',
        # 'Alvao.API.AI.Model',
        # 'Alvao.API.AI.Utils',
        # 'Alvao.API.AM',
        # 'Alvao.API.AM.Exceptions',
        # 'Alvao.API.AM.Model',
        # 'Alvao.API.Common',
        # 'Alvao.API.Common.Exceptions',
        # 'Alvao.API.Common.Model',
        # 'Alvao.API.Common.Model.Database',
        # 'Alvao.API.SD',
        # 'Alvao.API.SD.Exceptions',
        # 'Alvao.API.SD.Model',
        # 'Alvao.Context',
        'Alvao.Context.DB',
    ]

    CURRENT_CLASS = None
    version = []
    classes = []
    interfaces = []
    enumerations = []
    structures = []

    def parse(self, response):
        Helpers.assert_folder("html")

        for ns in self.namespaces:
            file = 'N_' + Helpers.htmlEncodeNamespace(ns) + '.htm'
            url = self.base_url + '/' + file
            print(f"Processing {ns} namespace")

            yield response.follow(url, self.parse_namespace)

    def parse_namespace(self, response):
        Helpers.dump_html(response)
        nsName: str = response.css(
            'div.toclevel1 > a[href^="../"]').css('::text').extract_first()

        # Process classes
        for cl in response.css('table#classList > tr:nth-child(n+2)').getall():
            _r = HtmlResponse(url="Cosi", body=cl, encoding='utf-8')
            name: str = _r.css(
                'tr > td:nth-child(2) > a::text').extract_first()
            type: str = _r.css(
                'tr > td:nth-child(1) > img::attr(title)').extract_first()
            href: str = _r.css(
                'tr > td:nth-child(2) > a::attr(href)').extract_first()

            print(f"   Processing class {name}")
            yield response.follow(f"{self.base_url}/{href}", self.parse_class)

    def parse_ctor(self, response):
        Helpers.dump_html(response)
        constructorDefinition: str = Helpers.inner_text(
            response, 'div#IDAB_code_Div1')

        self.CURRENT_CLASS.constructorDefinition = constructorDefinition
        print("Configuring constrdef")
        return "cosi"

    def parse_class(self, response):
        Helpers.dump_html(response)

        namespace: str = response.css(
            'div#TopicContent > a::text').extract_first()
        className: str = response.css(
            'html > head > title *::text').extract_first()
        className = className.replace('Class', '')
        className = className.strip()
        clazzDefinition: str = Helpers.inner_text(
            response, 'div#IDAB_code_Div1')

        self.CURRENT_CLASS = AlvaoClass(className)

        trs = response.xpath(
            "//table[@id='ConstructorList']/tr[position() >= 2]")
        for tr in trs:
            href = tr.css('tr > td > a::attr(href)').extract_first()
            _url = f"{self.base_url}/{href}"

            print(f"      Processing {className} constuctor")

            rsp = [scrapy.http.Request(_url,
                                       callback=self.parse_ctor)]
            print(rsp[0].text())

            # rsp = Reque response.follow(_url, self.parse_ctor)
            # print(rsp.body)

        print(self.CURRENT_CLASS.className)
        print(self.CURRENT_CLASS.constructorDefinition)
        print("class parsed")

        clazzBody: str = f"namespace {namespace};"

        # TODO: Usings from static file
        clazzBody = f"""{clazzBody}

        {clazzDefinition} {{
        """

        clazzBody = f"""
        {clazzBody}
        }}
        """
        Helpers.dump_file_in_ns(namespace, f"{className}.cs", clazzBody)


class Helpers():
    @staticmethod
    def dump_file_in_ns(namespace: str, fileName: str, fileBody: str):
        nsPath = namespace.replace('.', '/')
        nsPath = os.path.join("final", nsPath)
        Helpers.assert_folder(nsPath)

        nsPath = os.path.join(nsPath, fileName)
        Helpers.write_file(nsPath, fileBody)

        pass

    @staticmethod
    def inner_text(response, selector, delimiter="") -> str:
        all = response.css(f"{selector} *::text").getall()
        filtered_list = [string for string in all if string]

        return delimiter.join(filtered_list)

    @staticmethod
    def write_file(path, body):
        with open(path, 'w') as file:
            # Write some lines of text
            file.write(body)

    @staticmethod
    def dump_html(response):
        path: str = response.url.split("/")[-1]
        path = os.path.join("html", path)
        if not path.endswith(".htm"):
            path = os.path.join('htm', path)

        Helpers.write_file(path, response.text)

    @staticmethod
    def assert_folder(path):
        if os.path.exists(path):
            return

        os.makedirs(path)

    @staticmethod
    def htmlEncodeNamespace(ns: str) -> str:
        return (ns.replace('.', '_'))


class AlvaoClass(object):
    def __init__(self, className, constructorDefinition=None):
        self.className = className
        self.constructorDefinition = constructorDefinition
