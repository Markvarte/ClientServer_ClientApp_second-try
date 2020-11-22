# ClientServer_ClientApp_second-try
Working client part for repo ClientServer_ServerApp.

1)	Jāpalaiž servera programma. (#clientServer_ServerApp) (redzāmais tukšais komandas rindas logs)
2)	Jāpalaiž klienta programma. (#ClientServer_ClientApp_second-try) (redzamas vairākas opcijas)
3)	Jāizvēlās opcija –
3.1. - FIFO apstrade
3.2.. - MSMQ privatas rindas apstrade
3.3. - daltas atminas apstrade (faila nolasisana)
3.4. - iziet no programmas
4)	Pec izvēles jānospiež jebkurš taustiņš, lai iesāktu izvēlēta mehanisma darbīnu.
5)	3.3. un 3.4. gadījumā vairs neko ievadīt nevajag. 3.3. gadījumā notiek faila nolāsīšana un klientā cmd vidē var redzer servera izveidotā failā saturu, bet 3.4. gadījuma notiek izeja no programmas.
6)	Attiecīgi 3.1. un 3.2. gadījumā pēc savienošanas, lietotājs var sūtīt ziņas serverim un skatīties kā serveris tos saņem. Lai pārtrauktu ziņojumu sūtīšanu jāievada vārds “quit”.
