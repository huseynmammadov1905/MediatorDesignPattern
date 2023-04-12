
using MediatorDesignPattern;

HeyderAliyevAirport heyderAliyevAirport = new();


EnglandAirline englandAirline = new() { FlightNumber = "222",Airport = heyderAliyevAirport };
EnglandAirline englandAirline2 = new() { FlightNumber = "111",Airport = heyderAliyevAirport };
NorwayAirline norwayAirline = new() {FlightNumber = "444", Airport = heyderAliyevAirport };

heyderAliyevAirport.Register(englandAirline);
heyderAliyevAirport.Register(norwayAirline);

englandAirline.GetLandingPermission();
englandAirline2.GetLandingPermission();
norwayAirline.GetLandingPermission();



