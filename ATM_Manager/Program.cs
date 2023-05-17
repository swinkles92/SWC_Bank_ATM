using SWCBank;

ATM_Hub hub = new();
hub.startHub();

ATM chosenATM = SelectATMLocation(hub);
WriteLine($"You have chosen ATM {chosenATM.id_Num}");

