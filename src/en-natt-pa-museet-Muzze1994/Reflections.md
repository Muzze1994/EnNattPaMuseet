Navigering

För att navigera runt mellan olika rum och hur programmet ska veta vilka rum man får gå in i har jag skapat en lista med ConnectedRooms. En metod som jag skapat sätter skapade objekt (rum) i en speciell lista med ihopsatta rum. T.ex använder jag metoden ConnectToRoom för att sätta ihop rum 1 med rum 2. Då läggs rum 2 i rums 1 lista och rum 1 i rums 2 lista. Det är även en if-sats i metoden för att kolla om objekten redan är där för att inte skapa en oändlig loop. Sedan har jag gjort att varje rum har fått ett rumnummer. Dessa nummer används för att välja vilket rum man vill gå till. Detta ligger i en while-loop med en switch för att välja rum. Jag använder mig av en pointer och jämför den med varje rum jag ska gå in i. Jag använder mig av en metod CanWalkTo för att kolla att rummet som man försöker gå till är i listan på ConnectedRooms. Är det fallet så byts det rummet till currentroom och man får ut rummen i det objektets lista. Kan man inte gå till det rummet så blir det ett error som visas i konsollen att man inte kan gå till det rummet man försöker gå in i


Seperation

Jag använder mig enbart av console-commands i min program.cs för att separera logiken från konsol-klassen. 


Testning

Jag använder mig av tre enthetstester som kollar att ConnectToRoom-metoden fungerar som den ska, konstverk hamnar i rätt rum och att man inte kan teleportera till rum.
För att kolla så att ConnectToRoom-metoden fungerar har jag använt metoden på tre rum sedan kollat antalet objekt i ConnectedRooms-listan på varje rum. Om man sätter rum 1 med rum 2 så borde rum 1 ha ett objekt i sin lista och likaså rum 2. Men sätter man rum 2 med rum 3 och rum 1 så borde rum 2 ha två objekt i sin lista. Detta testades och verifierades så då fungerade metoden.
Jag testade min metod AddArtworkToList för att sätta in konstverk i t.ex rum 1 och sedan kollade antalet objekt i listan för rum 1 artworks. Lägger man in två objekt med konstverk i rum 1 så borde rum 1 ha två objekt i sin lista vilken den har. Testet har gått igenom.
Jag kollade även så att man inte kan gå till ett rum som inte är i listan på ConnectedRooms på just det rummet. Alltså att man inte kan teleportera till ett rum som inte är ihopsatt med ett annat rum. Sätter jag ihop rum 1 med rum 2 och rum 2 med rum 3 så ska man inte kunna gå från rum 1 till rum 3. Detta testar jag med min metod CanWalkTo vilket kollar vilket rum jag vill gå från och vilket rum jag vill gå till. Den kollar igenom så att det rummet man försöker gå till finns i listan på ConnectedRooms och tillåter då detta. Kan man gå från ett rum till ett annat ska det alltså bli true och kan man inte false. 

Övrigt

Jag har märkt en bugg i min kod som uppstår när man är i vissa rum med konstverk i. En viss del av informationen följer med in i andra rum beroende på hur många konstverk och vilket rum det är. Detta har jag inte hunnit lösa och skulle hemskt gärna vilja gå igenom varför detta händer i framtiden. Annars än det fungerar koden som det är tänkt att alla konstverk ritas ut för rätt rum osv.
