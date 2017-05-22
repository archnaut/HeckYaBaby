Imports System.Data.Entity
Imports Backend.Domain

Namespace Infrastructure
    Public Class ContextInitializer 
        Inherits DropCreateDatabaseAlways(Of DataContext)

        Protected Overrides Sub Seed(context As DataContext)
        
            context.Profiles.AddRange(New List(Of ProfileEntity) ({
                New ProfileEntity With {
                    .Name = "Travis, Hayfa M.",
                    .PhoneNumber = "(537) 188-4411",
                    .Address = "2353 Et, Av.",
                    .DateOfBirth = DateTime.Parse("07/20/1987"),
                    .FriendCount = 55,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Martin, Tyrone B.",
                    .PhoneNumber = "(873) 930-7882",
                    .Address = "9251 Laoreet Rd.",
                    .DateOfBirth = DateTime.Parse("02/01/1983"),
                    .FriendCount = 5,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Beck, Geoffrey J.",
                    .PhoneNumber = "(266) 884-0491",
                    .Address = "Ap #639-8127 Ipsum. Street",
                    .DateOfBirth = DateTime.Parse("09/07/1985"),
                    .FriendCount = 64,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Golden, Dorothy W.",
                    .PhoneNumber = "(828) 577-7837",
                    .Address = "230-162 Nisl Ave",
                    .DateOfBirth = DateTime.Parse("03/16/1965"),
                    .FriendCount = 43,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Oconnor, Ivy I.",
                    .PhoneNumber = "(376) 423-5794",
                    .Address = "1161 Augue, Road",
                    .DateOfBirth = DateTime.Parse("02/13/1961"),
                    .FriendCount = 89,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Madden, Elliott L.",
                    .PhoneNumber = "(867) 844-9407",
                    .Address = "P.O. Box 985, 184 Varius Rd.",
                    .DateOfBirth = DateTime.Parse("05/14/1985"),
                    .FriendCount = 90,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Mills, Nina R.",
                    .PhoneNumber = "(257) 488-2812",
                    .Address = "869-4168 Duis Road",
                    .DateOfBirth = DateTime.Parse("02/17/1928"),
                    .FriendCount = 81,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Schmidt, Isabella D.",
                    .PhoneNumber = "(981) 232-6656",
                    .Address = "Ap #289-3637 Egestas. Street",
                    .DateOfBirth = DateTime.Parse("03/30/1987"),
                    .FriendCount = 50,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Farrell, Ulla L.",
                    .PhoneNumber = "(921) 837-0259",
                    .Address = "626-9675 Semper Av.",
                    .DateOfBirth = DateTime.Parse("04/11/1938"),
                    .FriendCount = 94,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Murphy, Kameko E.",
                    .PhoneNumber = "(373) 848-9397",
                    .Address = "4701 Sed Ave",
                    .DateOfBirth = DateTime.Parse("11/29/1944"),
                    .FriendCount = 7,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Summers, Savannah X.",
                    .PhoneNumber = "(365) 949-6227",
                    .Address = "243-3010 Proin St.",
                    .DateOfBirth = DateTime.Parse("07/12/1949"),
                    .FriendCount = 25,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Tate, Brenna Q.",
                    .PhoneNumber = "(196) 304-2379",
                    .Address = "2945 Nec, Rd.",
                    .DateOfBirth = DateTime.Parse("05/25/1940"),
                    .FriendCount = 75,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Conrad, Hadassah H.",
                    .PhoneNumber = "(963) 359-3290",
                    .Address = "121-7328 Interdum. Road",
                    .DateOfBirth = DateTime.Parse("10/22/1936"),
                    .FriendCount = 94,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Castro, George H.",
                    .PhoneNumber = "(752) 272-4632",
                    .Address = "P.O. Box 981, 1540 Et Road",
                    .DateOfBirth = DateTime.Parse("06/22/1955"),
                    .FriendCount = 10,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Barron, Ocean B.",
                    .PhoneNumber = "(804) 979-6507",
                    .Address = "Ap #136-9721 Enim. Avenue",
                    .DateOfBirth = DateTime.Parse("11/06/1969"),
                    .FriendCount = 21,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Guy, Basia R.",
                    .PhoneNumber = "(573) 618-3124",
                    .Address = "Ap #116-3779 Nunc St.",
                    .DateOfBirth = DateTime.Parse("04/21/1978"),
                    .FriendCount = 39,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Jacobs, Deanna Y.",
                    .PhoneNumber = "(343) 745-6931",
                    .Address = "Ap #352-7404 Risus St.",
                    .DateOfBirth = DateTime.Parse("09/01/2002"),
                    .FriendCount = 39,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Gibson, Madison B.",
                    .PhoneNumber = "(949) 664-2117",
                    .Address = "Ap #328-4964 Eget Road",
                    .DateOfBirth = DateTime.Parse("08/25/1981"),
                    .FriendCount = 38,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Sullivan, Aristotle M.",
                    .PhoneNumber = "(270) 737-9832",
                    .Address = "Ap #817-508 Est St.",
                    .DateOfBirth = DateTime.Parse("07/08/2012"),
                    .FriendCount = 99,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Fulton, Derek M.",
                    .PhoneNumber = "(639) 743-0890",
                    .Address = "967-3580 Ac St.",
                    .DateOfBirth = DateTime.Parse("05/23/1919"),
                    .FriendCount = 9,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Barry, Jarrod Z.",
                    .PhoneNumber = "(876) 398-0419",
                    .Address = "520-5741 Sagittis Rd.",
                    .DateOfBirth = DateTime.Parse("07/25/1987"),
                    .FriendCount = 5,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Oneal, Caesar F.",
                    .PhoneNumber = "(443) 583-0866",
                    .Address = "618-137 Ullamcorper. Rd.",
                    .DateOfBirth = DateTime.Parse("03/18/1930"),
                    .FriendCount = 67,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Casey, Connor Z.",
                    .PhoneNumber = "(660) 368-9595",
                    .Address = "1932 Dui. Rd.",
                    .DateOfBirth = DateTime.Parse("08/27/1935"),
                    .FriendCount = 29,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Livingston, Jael A.",
                    .PhoneNumber = "(291) 974-4294",
                    .Address = "P.O. Box 476, 8579 Accumsan Rd.",
                    .DateOfBirth = DateTime.Parse("05/01/1976"),
                    .FriendCount = 1,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Foley, Stephanie G.",
                    .PhoneNumber = "(747) 478-4248",
                    .Address = "9797 Facilisis St.",
                    .DateOfBirth = DateTime.Parse("12/03/1929"),
                    .FriendCount = 4,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Gallagher, Bree R.",
                    .PhoneNumber = "(667) 552-8202",
                    .Address = "2338 Quis, Av.",
                    .DateOfBirth = DateTime.Parse("10/21/1947"),
                    .FriendCount = 4,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Cochran, Illiana L.",
                    .PhoneNumber = "(471) 632-6140",
                    .Address = "P.O. Box 583, 6957 Donec St.",
                    .DateOfBirth = DateTime.Parse("03/18/1952"),
                    .FriendCount = 57,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Simmons, Dexter Q.",
                    .PhoneNumber = "(689) 105-4665",
                    .Address = "Ap #697-7319 Libero Street",
                    .DateOfBirth = DateTime.Parse("07/16/2013"),
                    .FriendCount = 15,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Fox, Charlotte V.",
                    .PhoneNumber = "(392) 231-3109",
                    .Address = "P.O. Box 730, 1554 Dolor, Ave",
                    .DateOfBirth = DateTime.Parse("06/28/1967"),
                    .FriendCount = 83,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Stafford, Lareina N.",
                    .PhoneNumber = "(560) 323-1038",
                    .Address = "P.O. Box 138, 3433 Ridiculus Street",
                    .DateOfBirth = DateTime.Parse("10/14/1939"),
                    .FriendCount = 46,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Powell, Skyler X.",
                    .PhoneNumber = "(716) 299-3456",
                    .Address = "1289 Est Road",
                    .DateOfBirth = DateTime.Parse("12/13/1998"),
                    .FriendCount = 34,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Boyd, Cameran L.",
                    .PhoneNumber = "(718) 923-1840",
                    .Address = "316-8364 Sem Rd.",
                    .DateOfBirth = DateTime.Parse("04/08/2016"),
                    .FriendCount = 38,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Davenport, Abra J.",
                    .PhoneNumber = "(147) 952-1239",
                    .Address = "410-7559 Ligula. St.",
                    .DateOfBirth = DateTime.Parse("05/10/1933"),
                    .FriendCount = 61,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Burnett, Fletcher A.",
                    .PhoneNumber = "(394) 204-7935",
                    .Address = "647-3478 Sagittis Rd.",
                    .DateOfBirth = DateTime.Parse("03/25/1999"),
                    .FriendCount = 82,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Tyson, Christine V.",
                    .PhoneNumber = "(990) 707-7511",
                    .Address = "784-3015 Et St.",
                    .DateOfBirth = DateTime.Parse("03/08/1919"),
                    .FriendCount = 2,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Morgan, Kathleen S.",
                    .PhoneNumber = "(103) 126-5471",
                    .Address = "5895 Massa. Street",
                    .DateOfBirth = DateTime.Parse("02/25/1991"),
                    .FriendCount = 40,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Sawyer, Kylynn M.",
                    .PhoneNumber = "(404) 342-6547",
                    .Address = "Ap #885-3949 Ultrices Street",
                    .DateOfBirth = DateTime.Parse("03/11/2004"),
                    .FriendCount = 65,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Wiggins, Virginia W.",
                    .PhoneNumber = "(331) 111-8174",
                    .Address = "8424 Malesuada Street",
                    .DateOfBirth = DateTime.Parse("08/04/1971"),
                    .FriendCount = 89,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Martin, Allegra J.",
                    .PhoneNumber = "(749) 991-2517",
                    .Address = "P.O. Box 218, 6594 Cras Street",
                    .DateOfBirth = DateTime.Parse("01/07/1952"),
                    .FriendCount = 94,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Cruz, Inga L.",
                    .PhoneNumber = "(867) 180-2967",
                    .Address = "P.O. Box 149, 4167 Enim. Road",
                    .DateOfBirth = DateTime.Parse("06/12/1929"),
                    .FriendCount = 86,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Harrison, Nathan E.",
                    .PhoneNumber = "(877) 494-5864",
                    .Address = "5320 Est, St.",
                    .DateOfBirth = DateTime.Parse("11/15/1950"),
                    .FriendCount = 25,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Pitts, Morgan B.",
                    .PhoneNumber = "(994) 460-0326",
                    .Address = "P.O. Box 626, 2235 Duis St.",
                    .DateOfBirth = DateTime.Parse("12/20/1986"),
                    .FriendCount = 49,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Gay, Garrett M.",
                    .PhoneNumber = "(465) 804-2129",
                    .Address = "960-9985 Odio Av.",
                    .DateOfBirth = DateTime.Parse("04/15/1933"),
                    .FriendCount = 60,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Bass, Roanna J.",
                    .PhoneNumber = "(610) 506-6538",
                    .Address = "Ap #782-190 Scelerisque Avenue",
                    .DateOfBirth = DateTime.Parse("10/22/2011"),
                    .FriendCount = 6,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Wooten, Sonia Z.",
                    .PhoneNumber = "(259) 592-0493",
                    .Address = "P.O. Box 542, 6301 Rutrum Rd.",
                    .DateOfBirth = DateTime.Parse("09/16/1958"),
                    .FriendCount = 6,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Dixon, Sheila H.",
                    .PhoneNumber = "(563) 693-0182",
                    .Address = "P.O. Box 591, 8200 Quis, Avenue",
                    .DateOfBirth = DateTime.Parse("11/27/1936"),
                    .FriendCount = 43,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Parker, David A.",
                    .PhoneNumber = "(442) 368-3408",
                    .Address = "4126 Vel, St.",
                    .DateOfBirth = DateTime.Parse("12/14/1922"),
                    .FriendCount = 29,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Hodge, Carol W.",
                    .PhoneNumber = "(454) 540-8792",
                    .Address = "559-6031 In Ave",
                    .DateOfBirth = DateTime.Parse("05/06/1979"),
                    .FriendCount = 37,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Goodman, Pearl O.",
                    .PhoneNumber = "(773) 542-6462",
                    .Address = "2144 At Av.",
                    .DateOfBirth = DateTime.Parse("12/28/1955"),
                    .FriendCount = 99,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Delacruz, Blossom W.",
                    .PhoneNumber = "(928) 378-7971",
                    .Address = "887-6131 Fusce Road",
                    .DateOfBirth = DateTime.Parse("05/06/1975"),
                    .FriendCount = 52,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Henry, Felix M.",
                    .PhoneNumber = "(437) 912-9576",
                    .Address = "Ap #541-957 Dignissim Ave",
                    .DateOfBirth = DateTime.Parse("11/24/1952"),
                    .FriendCount = 49,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Hayes, Rhonda F.",
                    .PhoneNumber = "(780) 257-0894",
                    .Address = "6212 Ornare, Rd.",
                    .DateOfBirth = DateTime.Parse("11/27/1963"),
                    .FriendCount = 4,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Macias, Silas V.",
                    .PhoneNumber = "(945) 481-6078",
                    .Address = "P.O. Box 989, 7941 Mattis Street",
                    .DateOfBirth = DateTime.Parse("03/09/1958"),
                    .FriendCount = 73,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Little, Marny C.",
                    .PhoneNumber = "(413) 438-0206",
                    .Address = "Ap #519-8399 Mauris, St.",
                    .DateOfBirth = DateTime.Parse("05/08/1949"),
                    .FriendCount = 7,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Hogan, Pearl M.",
                    .PhoneNumber = "(478) 280-5209",
                    .Address = "1676 Ornare, Avenue",
                    .DateOfBirth = DateTime.Parse("04/21/1992"),
                    .FriendCount = 49,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Mccarthy, Wylie O.",
                    .PhoneNumber = "(152) 782-9913",
                    .Address = "287-6028 Est. St.",
                    .DateOfBirth = DateTime.Parse("07/27/1922"),
                    .FriendCount = 54,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Middleton, Keane V.",
                    .PhoneNumber = "(716) 362-2736",
                    .Address = "9392 Arcu. Ave",
                    .DateOfBirth = DateTime.Parse("02/23/1944"),
                    .FriendCount = 43,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Chandler, Fleur F.",
                    .PhoneNumber = "(416) 411-5982",
                    .Address = "P.O. Box 271, 8052 Integer Ave",
                    .DateOfBirth = DateTime.Parse("03/06/1991"),
                    .FriendCount = 23,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Sherman, Cassidy J.",
                    .PhoneNumber = "(509) 951-2060",
                    .Address = "P.O. Box 677, 5542 Vitae Street",
                    .DateOfBirth = DateTime.Parse("10/26/1955"),
                    .FriendCount = 65,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Rojas, Iliana F.",
                    .PhoneNumber = "(149) 910-0229",
                    .Address = "Ap #569-8413 Odio. Ave",
                    .DateOfBirth = DateTime.Parse("09/23/1941"),
                    .FriendCount = 58,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Buckner, Oleg U.",
                    .PhoneNumber = "(983) 325-7143",
                    .Address = "981-2370 Aliquam Ave",
                    .DateOfBirth = DateTime.Parse("11/11/1957"),
                    .FriendCount = 91,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Boyle, Rogan L.",
                    .PhoneNumber = "(813) 774-8657",
                    .Address = "958-290 Ante Road",
                    .DateOfBirth = DateTime.Parse("08/12/1950"),
                    .FriendCount = 54,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Bowen, Hadley B.",
                    .PhoneNumber = "(576) 648-0838",
                    .Address = "939-9582 Auctor, St.",
                    .DateOfBirth = DateTime.Parse("03/17/1970"),
                    .FriendCount = 15,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Hendrix, Burke D.",
                    .PhoneNumber = "(109) 628-0325",
                    .Address = "P.O. Box 941, 8395 Malesuada Av.",
                    .DateOfBirth = DateTime.Parse("07/10/1926"),
                    .FriendCount = 92,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Newman, Lucy I.",
                    .PhoneNumber = "(672) 641-4880",
                    .Address = "791-4697 Penatibus Street",
                    .DateOfBirth = DateTime.Parse("09/16/1987"),
                    .FriendCount = 14,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Dodson, Macon A.",
                    .PhoneNumber = "(929) 550-0116",
                    .Address = "P.O. Box 379, 5351 Odio Av.",
                    .DateOfBirth = DateTime.Parse("11/18/2006"),
                    .FriendCount = 23,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Ferrell, Valentine S.",
                    .PhoneNumber = "(950) 771-7415",
                    .Address = "P.O. Box 377, 6351 Phasellus Avenue",
                    .DateOfBirth = DateTime.Parse("05/25/1944"),
                    .FriendCount = 70,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Casey, Chantale U.",
                    .PhoneNumber = "(406) 616-7938",
                    .Address = "495-5260 Arcu. Ave",
                    .DateOfBirth = DateTime.Parse("06/23/1957"),
                    .FriendCount = 56,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Alvarado, Victoria A.",
                    .PhoneNumber = "(935) 558-1218",
                    .Address = "8059 Ad St.",
                    .DateOfBirth = DateTime.Parse("03/13/1974"),
                    .FriendCount = 4,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Zamora, Warren L.",
                    .PhoneNumber = "(322) 543-7988",
                    .Address = "304-3600 Metus. Rd.",
                    .DateOfBirth = DateTime.Parse("01/05/1962"),
                    .FriendCount = 30,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Maddox, Xena H.",
                    .PhoneNumber = "(205) 265-8160",
                    .Address = "P.O. Box 360, 7982 Neque Av.",
                    .DateOfBirth = DateTime.Parse("01/31/1960"),
                    .FriendCount = 18,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Hamilton, Jacob Z.",
                    .PhoneNumber = "(288) 791-5050",
                    .Address = "P.O. Box 692, 378 Tempus St.",
                    .DateOfBirth = DateTime.Parse("10/14/1984"),
                    .FriendCount = 17,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Little, Whilemina X.",
                    .PhoneNumber = "(681) 129-0413",
                    .Address = "707-4964 Lacus. Rd.",
                    .DateOfBirth = DateTime.Parse("01/25/1928"),
                    .FriendCount = 7,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Hill, Paul Y.",
                    .PhoneNumber = "(150) 449-3330",
                    .Address = "Ap #885-1691 Eget, Rd.",
                    .DateOfBirth = DateTime.Parse("10/16/1988"),
                    .FriendCount = 72,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Moreno, Francesca S.",
                    .PhoneNumber = "(391) 797-7493",
                    .Address = "P.O. Box 805, 5101 Habitant Ave",
                    .DateOfBirth = DateTime.Parse("05/13/2012"),
                    .FriendCount = 26,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Good, Hermione S.",
                    .PhoneNumber = "(761) 825-7330",
                    .Address = "P.O. Box 446, 447 Ante Rd.",
                    .DateOfBirth = DateTime.Parse("10/12/1945"),
                    .FriendCount = 5,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Murray, Denton K.",
                    .PhoneNumber = "(400) 770-9177",
                    .Address = "318-7995 Integer Ave",
                    .DateOfBirth = DateTime.Parse("05/18/1964"),
                    .FriendCount = 69,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Richard, Leah F.",
                    .PhoneNumber = "(950) 348-6854",
                    .Address = "Ap #722-568 Sit Rd.",
                    .DateOfBirth = DateTime.Parse("06/18/1961"),
                    .FriendCount = 32,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Hoffman, Ella Q.",
                    .PhoneNumber = "(729) 543-0974",
                    .Address = "296-7514 Tempor Rd.",
                    .DateOfBirth = DateTime.Parse("08/25/1931"),
                    .FriendCount = 77,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Figueroa, Bruce Z.",
                    .PhoneNumber = "(697) 399-8865",
                    .Address = "P.O. Box 680, 2710 Donec Rd.",
                    .DateOfBirth = DateTime.Parse("02/03/1918"),
                    .FriendCount = 19,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Mckee, Deacon O.",
                    .PhoneNumber = "(871) 448-6444",
                    .Address = "744 Pulvinar Rd.",
                    .DateOfBirth = DateTime.Parse("01/26/1990"),
                    .FriendCount = 67,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Garza, Dorian R.",
                    .PhoneNumber = "(395) 351-2045",
                    .Address = "888-116 Amet Rd.",
                    .DateOfBirth = DateTime.Parse("03/30/1941"),
                    .FriendCount = 98,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Haney, Lesley T.",
                    .PhoneNumber = "(610) 890-8919",
                    .Address = "425-2875 Nisi. Ave",
                    .DateOfBirth = DateTime.Parse("09/23/1987"),
                    .FriendCount = 15,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Donaldson, Shea C.",
                    .PhoneNumber = "(217) 904-3458",
                    .Address = "P.O. Box 161, 3230 A St.",
                    .DateOfBirth = DateTime.Parse("04/29/1983"),
                    .FriendCount = 61,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Fowler, Steven M.",
                    .PhoneNumber = "(562) 214-9435",
                    .Address = "Ap #821-7730 Felis St.",
                    .DateOfBirth = DateTime.Parse("05/21/1997"),
                    .FriendCount = 66,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Kaufman, Laith F.",
                    .PhoneNumber = "(830) 401-6775",
                    .Address = "7902 Curabitur St.",
                    .DateOfBirth = DateTime.Parse("02/07/1980"),
                    .FriendCount = 1,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Bradford, Chester X.",
                    .PhoneNumber = "(360) 817-7411",
                    .Address = "933-8426 Magna. St.",
                    .DateOfBirth = DateTime.Parse("04/27/1957"),
                    .FriendCount = 19,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Hancock, Suki Y.",
                    .PhoneNumber = "(657) 904-4216",
                    .Address = "P.O. Box 199, 4113 Tellus Avenue",
                    .DateOfBirth = DateTime.Parse("10/30/1934"),
                    .FriendCount = 42,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Thornton, Fatima A.",
                    .PhoneNumber = "(968) 492-8247",
                    .Address = "309-1985 Mauris Ave",
                    .DateOfBirth = DateTime.Parse("04/03/2008"),
                    .FriendCount = 55,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Harmon, Samuel Z.",
                    .PhoneNumber = "(407) 463-7886",
                    .Address = "P.O. Box 365, 7021 Vitae, Avenue",
                    .DateOfBirth = DateTime.Parse("02/19/1954"),
                    .FriendCount = 36,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Newton, Otto I.",
                    .PhoneNumber = "(518) 359-3900",
                    .Address = "9903 Tempor Avenue",
                    .DateOfBirth = DateTime.Parse("08/29/1928"),
                    .FriendCount = 37,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Dickson, Devin F.",
                    .PhoneNumber = "(612) 309-4671",
                    .Address = "309-9343 Mollis. Av.",
                    .DateOfBirth = DateTime.Parse("12/11/1924"),
                    .FriendCount = 88,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Kirkland, Jacqueline C.",
                    .PhoneNumber = "(448) 186-7719",
                    .Address = "P.O. Box 557, 9074 Vitae, Rd.",
                    .DateOfBirth = DateTime.Parse("11/11/1960"),
                    .FriendCount = 59,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Williams, Amery Z.",
                    .PhoneNumber = "(844) 844-8956",
                    .Address = "Ap #749-9940 Non Road",
                    .DateOfBirth = DateTime.Parse("03/26/1928"),
                    .FriendCount = 9,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Cohen, Carter D.",
                    .PhoneNumber = "(280) 548-9942",
                    .Address = "714-4630 Massa. Ave",
                    .DateOfBirth = DateTime.Parse("01/25/2001"),
                    .FriendCount = 100,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Ochoa, Jesse R.",
                    .PhoneNumber = "(726) 103-5812",
                    .Address = "822-9794 Consequat, Ave",
                    .DateOfBirth = DateTime.Parse("08/11/1933"),
                    .FriendCount = 7,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Moran, Savannah M.",
                    .PhoneNumber = "(779) 999-7338",
                    .Address = "603-3191 Ultricies Rd.",
                    .DateOfBirth = DateTime.Parse("03/16/1975"),
                    .FriendCount = 28,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Oneill, Sade S.",
                    .PhoneNumber = "(284) 493-0219",
                    .Address = "Ap #328-4807 Ipsum Avenue",
                    .DateOfBirth = DateTime.Parse("10/30/1988"),
                    .FriendCount = 64,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Durham, Juliet S.",
                    .PhoneNumber = "(740) 679-9788",
                    .Address = "Ap #284-5826 Risus Rd.",
                    .DateOfBirth = DateTime.Parse("04/05/1922"),
                    .FriendCount = 69,
                    .Active = True
                },
                New ProfileEntity With {
                    .Name = "Foreman, Joelle B.",
                    .PhoneNumber = "(962) 192-1119",
                    .Address = "202-1000 Vulputate St.",
                    .DateOfBirth = DateTime.Parse("01/21/1937"),
                    .FriendCount = 31,
                    .Active = True
                }
            }))
        End Sub
    End Class
End NameSpace