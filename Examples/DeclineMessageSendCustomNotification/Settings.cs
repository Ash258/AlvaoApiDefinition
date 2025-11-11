using System;
using System.Collections.Generic;
using System.IO;

public static class Settings
{
    // Services on which the automatic action is triggered.
    // Enter service IDs, separated by commas.
    public static int[] SupportedServices = { }; // Example service IDs: 1, 2, 3

    // Example of mail message.
	public static string MailMessageCzech = 
		"Dobrý den, \r\n\r\n" +
		"odeslali jste zprávu na adresu, která slouží pouze pro komunikaci v rámci řešení požadavků v systému ALVAO.\r\n" +
		"Pro založení požadavku/nahlášení incidentu přejděte prosím na: https://servicedesk.contoso.com/Alvao/\r\n" +
		"V případě, že potřebujete kontaktovat oddělení, které má tuto oblast na starosti, použijte prosím kontakty dostupné na intranetu.\r\n\r\n" +
		"Děkujeme za pochopení,\r\n" + 
		"Tým ALVAO SD \r\n\r\n\r\n";

	public static string MailMessageEnglish = 
		"Hello, \r\n\r\n" +
		"You have sent a message to an address that is only used for communication within the ALVAO system.\r\n" +
		"To create a request/incident report, please go to: https://servicedesk.contoso.com/Alvao/\r\n" +
		"In case you need to contact the department in charge of this area, please use the contacts available on the intranet.\r\n\r\n" +
		"Thank you for your understanding,\r\n" + 
		"ALVAO SD team \r\n\r\n\r\n";
}
