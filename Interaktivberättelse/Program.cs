using System;

string Val = "";

Console.WriteLine("Du går i en skog och är påväg hem från en fest, när du tittar åt vänster så ser du ett ödelagt hus.");
Console.WriteLine("Du är fortfarande lite full efter allt drickande, utan att tänka på konsekvenserna så går du mot stugan eftersom den påminner om din favoritfilm (Modig).");
Console.WriteLine("Du går fram till ett fönster och kollar försiktigt in men du ser inget då allt är kolsvart inne i stugan.");
Console.WriteLine("Du väljer att knacka på dörren men ingen öppnar.");
Console.WriteLine("Smart som du är så väljer du att dra i handtaget för att se om det är öppet, Det är det!");
Console.WriteLine("När du kollar in genom springan i dörren så ser du en 100-Lapp på ett litet bord och väljer att gå in för att ta den.");
Console.WriteLine("På vägen till bordet så hör du en smäll och dörren du kom in genom är inte bara stängd utan helt borta.");
Console.WriteLine("Du blir rädd och försöker hitta en väg ut. Du kollar runt i rummet och ser en svart och en brun dörr.");
Console.WriteLine("Vilken av dörrarna väljer du?");
Console.WriteLine("Svart eller Brun?");
Console.WriteLine("");
Val = Console.ReadLine();


if (Val == "svart" || Val == "Svart")
{
    Console.WriteLine("Du går mot den svarta dörren och drar i handtaget. Dörren öppnas och där finns ett badrum.");
    Console.WriteLine("Samma sekund som du tittar in i badrummet så hoppar en människa upp ur toaletten och landar framför dig.");
    Console.WriteLine("Det första du lägger märke till är att han har en toalettsits runt halsen som om det vore ett halsband.");
    Console.WriteLine("Men... du hinner knappt få ut ett skrik innan DR. MUGG dödar dig med vaskrensaren som han har i handen.");
    Console.WriteLine("");
    Console.WriteLine("GAME OVER!");

}
else if (Val == "Brun" || Val == "brun")
{
    Console.WriteLine("Du går mot den bruna dörren och drar i handtaget. Dörren öppnas och där finns en matsal.");
    Console.WriteLine("Du kollar försiktigt in och ser att det inte är någon där.");
    Console.WriteLine("Du väljer att ta några steg in i matsalen och då ser du yttligare två dörrar.");
    Console.WriteLine("En Grön och En Lila.");
    Console.WriteLine("Vilken av dörrarna väljer du?");
    Console.WriteLine("");
    Val = Console.ReadLine();


if (Val == "Grön" || Val == "grön")
{
    Console.WriteLine("Du skyndar till den gröna dörren och öppnar den.");
    Console.WriteLine("När dörren öppnas känner du en stark lukt av cigarettrök.");
    Console.WriteLine("Lampan tänds i rummet och mindre än en meter framför dig står Cruella De Vil.");
    Console.WriteLine("Hon tar tag i dig, stänger dörren bakom dig, släcker lampan och sedan gör en rock av ditt skinn.");
    Console.WriteLine("");
    Console.WriteLine("GAME OVER!");
}

if (Val == "Lila" || Val == "lila")
{
    Console.WriteLine("Du skyndar till den lila dörren och när du öppnar den kommer du in till ett arbetsrum.");
    Console.WriteLine("Du kollar runt i rummet, ingen här!");
    Console.WriteLine("Dina ögon dras till en öppen spis som finns i rummet och du tänker 'Jag undrar om man kan rymma härifrån genom att klättra ut ur skorstenen?'.");
    Console.WriteLine("Du går ett steg mot den öppna spisen medans du fortsätter kolla runt i rummet.");
    Console.WriteLine("När du kollar åt höger ser du en röd dörr. Du stannar upp och börjar fundera på vilken väg du ska ta.");
    Console.WriteLine("Vad väljer du?");
    Console.WriteLine("Öppna spisen eller Röda dörren?");
    Console.WriteLine("");
    Val = Console.ReadLine();
}
if ( Val == "Öppna spisen" || Val == "öppna spisen" )
{
    Console.WriteLine("Du går mot den öppna spisen med raska steg.");
    Console.WriteLine("När du står framför den öppna spisen så ställer du dig på huk, sticker in huvudet i öppningen och kollar upp.");
    Console.WriteLine("Allt är kolsvart men du bestämmer dig för att göra ett försök, så du börjar klättra på väggarna inne i den öppna spisen.");
    Console.WriteLine("Efter ungefär 20 sekunders klättrande så hoppar jultomten ner genom skorstenen och äter upp dig.");
    Console.WriteLine("");
    Console.WriteLine("GAME OVER!");
}
if (Val == "Röda dörren" || Val == "röda dörren")
{
    Console.WriteLine("Du småspringer mot den röda dörren och sliter i handtaget.");
    Console.WriteLine("När dörren öppnas blir du bländad av ett starkt ljus.");
    Console.WriteLine("Det tar dina ögon några sekunder att vänja sig men du ser tillslut ett fönster på väggen mitt emot dig.");
    Console.WriteLine("Utanför fönstret ser du skogen som du gick i innan du valde att gå in i stugan.");
    Console.WriteLine("På väggen vänster om fönstret ser du ännu en dörr.");
    Console.WriteLine("Denhär gången är det en stor orange dubbeldörr.");
    Console.WriteLine("Vilken av dem väljer du?");
    Console.WriteLine("Fönstret eller Dubbeldörren?");
    Console.WriteLine("");
    Val = Console.ReadLine();

if (Val == "Fönstret" || Val == "fönstret")
{
    Console.WriteLine("Du springer snabbt mot fönstret och när du kommer fram inser du att det inte finns något sätt att öppna fönstret.");
    Console.WriteLine("Från ingen stans hör du en stor smäll som verkar komma någonstans inifrån huset.");
    Console.WriteLine("Du får panik och väljer att försöka krossa fönstret genom att hoppa igenom det.");
    Console.WriteLine("Du tar sats, springer allt du har, hoppar upp mot fönstret och kupar ihop dig till en boll för att få så lite skada som möjligt av glaset.");
    Console.WriteLine("När du träffar fönstret så spricker glaset men du har otur!");
    Console.WriteLine("På marken under fönstret står lejonet ASLAN. Du flyger rakt in i hans stora mun och han sväljer dig hel.");
    Console.WriteLine("");
    Console.WriteLine("GAME OVER!");
    Val = Console.ReadLine();
}
if (Val == "Dubbeldörren" || Val == "dubbeldörren")
{
    Console.WriteLine("Du springer fram och rycker i ett av handtagen på dubbeldörren. LÅST!?");
    Console.WriteLine("Du testar dra i andra handtaget och till din förvåning. ÖPPET!");
    Console.WriteLine("Du öppnar dörren långsamt och en lättnad sprider sig i din kropp.");
    Console.WriteLine("Du är tillbaka i skogen där du började innan du gick in i stugan.");
    Console.WriteLine("Du springer mot ditt hem så snabbt du kan och medans så kollar du ner i din hand.");
    Console.WriteLine("Där ligger 100-Lappen som du hittade i början. YAAAY!");
    Console.WriteLine("");
    Console.WriteLine("DU VANN SPELET!!");
}
}
}
    Console.WriteLine("");
    Console.WriteLine("Tryck ENTER för att avsluta spelet");
    Console.ReadLine();