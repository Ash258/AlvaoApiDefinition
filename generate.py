import scrapy
import os
from scrapy.http import HtmlResponse

ALVAO_VERSION = '11.2'

# curl 'https://doc.alvao.com/en/alvao_11_2/alvao_api/html/N_Alvao_API_AI.htm' \
#     - H 'Accept: text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7' \
#     - H 'Accept-Language: en-GB,en-US;q=0.9,en;q=0.8' \
#     - H 'Cache-Control: no-cache' \
#     - H 'Connection: keep-alive' \
#     - H 'Pragma: no-cache' \
#     - H 'Sec-Fetch-Dest: document' \
#     - H 'Sec-Fetch-Mode: navigate' \
#     - H 'Sec-Fetch-Site: none' \
#     - H 'Sec-Fetch-User: ?1' \
#     - H 'Upgrade-Insecure-Requests: 1' \
#     - H 'User-Agent: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36' \
#     - H 'sec-ch-ua: "Not/A)Brand";v="8", "Chromium";v="126", "Wavebox";v="126"' \
#     - H 'sec-ch-ua-mobile: ?0' \
#     - H 'sec-ch-ua-platform: "macOS"'


class AlvaoSpider(scrapy.Spider):
    name = 'alvaospider'
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

    version = []
    classes = []
    interfaces = []
    enumerations = []
    structures = []

    def parse(self, response):
        Helpers.assert_folder("html")

        for ns in self.namespaces:
            print(f"Processing {ns} namespace")
            file = 'N_' + Helpers.htmlEncodeNamespace(ns) + '.htm'
            url = self.base_url + '/' + file
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

            print(f"=====>{self.base_url}/{href}.htm")
            self.parse_class(
                f"{self.base_url}/{href}.htm")

        return

        # Create final folder
        base_path: str = "final"
        ns_path: str = base_path
        self.assert_folder(ns_path)

        # Create namespace folder
        for folder in nsName.split('.'):
            ns_path = os.path.join(ns_path, folder)
            self.assert_folder(ns_path)

    def parse_class(self, url: str):
        response = HtmlResponse(url=url, body=None, encoding='utf-8')
        print(response.css('div#IDAB_code_Div1').extract_first())
        # TODO: Implement


class Helpers():
    @staticmethod
    def write_file(path, body):
        with open(path, 'w') as file:
            # Write some lines of text
            file.write(body)

    @staticmethod
    def dump_html(response):
        path: str = response.url.split("/")[-1]
        Helpers.write_file(os.path.join('html', path), response.text)

    @staticmethod
    def assert_folder(path):
        if os.path.exists(path):
            return

        os.makedirs(path)

    @staticmethod
    def htmlEncodeNamespace(ns: str) -> str:
        return (ns.replace('.', '_'))
