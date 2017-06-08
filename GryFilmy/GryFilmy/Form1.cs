/* 
Zajęcia WSTI.NET 12.04.2017
Windows Forms
Dawid Dziedzic
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Podłączamy sobie przestrzenie nazw, które zawierają niezbędne dla nas klasy, ich metody, które wykorzystamy w aplikacji
using System.Xml.Serialization; // niezbędne aby skorzystać z serializacji XML
using System.IO; // niezbędne, aby skorzystać z klas TextWriter, TextReader

/*
 * Aplikacja ma służyć za prosty przykład klas, ich obiektów oraz operacji na ich polach
 * Wykorzystuje serializację XML - tj. zapis obiektów do pliku .XML - taka nasza baza danych - serializacja to nic innego jak zapis, deserializacja to odczyt
 * Pokazuje operacje na komponentach formy, tj. wykorzystuje eventy(zdarzenia)
 * 
 * Prezentuje komponenty takie jak - w głównej formie MainForm.cs - jest to nasze główne okienko:
 * ListView - to jest nasza duża lista o nazwie ProductList - zdecydowałem się na nią ponieważ w bardzo ładny sposób pozwala na grupowanie elementów
 * Podelementy(klasy) ListView to: ListViewItem - element tego komponentu czyli pojedyncza pozycja na liście, ListViewGroup - grupa, w której znajdują się jakieś elementy typu ListViewItem
 * Button - przyciski
 * PictureBox - obrazki
 * Label - fragmenty tekstu, np jakiś nagłówek
 * ContextMenuStrip - jest to menu, wywoływane prawym przyciskiem myszy, w tej aplikacji podłączone pod komponent ProductList(ListView)
 * MenuStrip - jest to menu główne aplikacji, ulokowane na samej górze(Plik)
 * OpenFileDialog - jest to komponent, który pozwala nam na wyświetlenie dialogu do otwarcia jakiegoś pliku
 * SaveFileDialog - jak wyżej, tylko do zapisu
 * 
 * Natomiast forma dodawania produktu, tj. AddForm.cs prezentuje nastepujące komponenty:
 * TabControl - przełączanie pomiędzy zakładkami, tj. Gra, Film, Książka
 * TextBox - pole tekstowe do którego użytkownik może coś wpisać, itd.
 * Label - fragmenty tekstu, np jakiś nagłówek
 * Button - przyciski
 * ComboBox - rozwijany komponent, który pozwala nam na wybór jednego elementu
 * NumericUpDown - za pomocą strzałek pozwala nam na inkrementacje/dekrementacje jakiejś wartości liczbowej, tutaj skonfigurowany że pokazuje również do 2 miejsc po przecinku
 * DateTimePicker - komponent pozwalający nam na wybór daty
 * CheckBox - "ptaszkowanie", "odptaszkowanie" czyli zaznaczanie jakiejś wartości typu prawda/fałsz
 * 
 * Po zapoznaniu się z kodem i z funkcjonalnością zachęcam do modyfikacji tej aplikacji, rozszerzenia jej, bądź po prostu niech służy za gotowca w jakiś innych projektach, pracach
 * Uważam, że mając wgląd w coś co już działa, istnieje, łatwiej jest nam poznać z czym to się wszystko je, jaką strukture wykorzystać, co robić niż brać wszystko z głowy
 * Mam nadzieje, że ta aplikacja będzie fajnym podsumowaniem tego, co do tej pory było powiedziane o obiektowości i przy okazji kogoś zachęci do głębszej nauki języka C# :)
 * Zanim podejdziesz do kodu zachęcam do przetestowania aplikacji "w akcji", żeby zapoznać się z tym jak działa
 * Zapraszam do dalszej lektury i zapoznania się z tym co jest pod maską :)
*/

namespace GryFilmy // Przestrzeń nazw naszego projektu
{
    public partial class MainForm : Form // Klasa główna aplikacji
    {
        // Korzystać będziemy z regionów, łatwiej się połapać co jest gdzie - przykład dobrej organizacji kodu :)
        // Nazwy metod, zmiennych, itd. również są w języku angielskim - jest to język uniwersalny i zachęcam do takiej praktyki

        #region NASZE DEKLARACJE

        // Tworzymy obiekty typu ListViewGroup, są to grupy do naszego ProductList(patrz komponent, który wygląda jak lista)
        private ListViewGroup books = new ListViewGroup();
        private ListViewGroup games = new ListViewGroup();
        private ListViewGroup videos = new ListViewGroup();
        // Tworzymy List<T>, tj. listę zawierającą w tym przypadku obiekty typu Product, List<T> to kolekcja generyczna, odsyłam do MSDN:
        // https://msdn.microsoft.com/pl-pl/library/6sh2ey19(v=vs.110).aspx
        // Odnośnie obiektów typu Product, patrz plik Product.cs w Solution Explorerze, jest to utworzona przeze mnie klasa
        private List<Product> listOfProducts = new List<Product>();
        // Jest to lista, która będzie zawierała wszystkie produkty, tj. tak jak w logice aplikacji - gry, filmy, książki

        #endregion

        #region NASZE METODY

        /* 
         * Poniżej są zawarte zaimplementowane metody, kilka słów o nich
         * Serializacja jak wspominałem już wyżej, pozwala nam na zapis przykładowo naszej listy do pliku .XML - będzie ona tam miała odpowiednią strukturę
         * Serializując zapisujemy listę do owego pliku, deserializując ją odczytujemy
         * 
         * Mają miejsce dwie definicje metody Serialize oraz Deserialize, jak to jest możliwe? Jest to tak zwany polimorfizm statyczny - przeładowanie metod(z ang. overloading)
         * Jedyne czym się różnią to ilością parametrów, czyli w dwojaki sposób możemy skorzystać z owych metod, albo podać 1 parametr, albo 2 parametry
         * Co do reszty zapraszam poniżej :)
         */

        // Czyli tutaj mieści się nasza metoda Serialize, jest ona typu void, to znaczy że nic nie zwróci(nie będzie słówka kluczowego return)
        // Przyjmuje ona 1 parametr, jest to lista produktów(obiektów typu Product, patrz Product.cs) o nazwie "list"
        private void Serialize(List<Product> list)
        {
            // Do zmiennej typu string o nazwie "currentDirectory" pobieramy ścieżkę katalogu, z którego została uruchomiona aplikacja
            // tj. ta linijka: System.AppDomain.CurrentDomain.BaseDirectory
            // znakiem '+' podłączamy do niej jeszcze nazwę pliku, pozwoliłem sobie tutaj zrobić plik domyślny baza_produktow.xml i go troszkę uzupełnić produktami(obiektami typu Product)
            string currentDirectory = System.AppDomain.CurrentDomain.BaseDirectory + "baza_produktow.xml";

            // Tworzymy tutaj obiekt "serializer" typu XmlSerializer, czyli tworzymy nasz serializer XML, który będzie serializował(zapisywał) obiekty typu(typeof) List<Product>
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
            // Po opis składni odsyłam do MSDN: https://msdn.microsoft.com/pl-pl/library/system.xml.serialization.xmlserializer(v=vs.110).aspx
            // Warto zapoznać się ze składnią metody Serialize, będzie ona niżej wykorzystywana

            // Tworzymy sobie "writer" typu TextWriter, jest to klasa abstrakcyjna, która reprezentuje sposób, w jaki będziemy zapisywali plik
            // do "writer" przypisujemy obiekt typu StreamWriter - tutaj są określane takie rzeczy jak kodowanie, rozmiar buforu - nie zagłębiajmy się w to
            // jako parametr podajemy mu ścieżkę currentDirectory
            TextWriter writer = new StreamWriter(currentDirectory);

            // Korzystając z utworzonego przez nas serialiera "serializer", wykorzystujemy jego metodę Serialize, której podajemy następujące parametry, tj. writer oraz list
            // "writer" to utworzone przez nas, nazwijmy to "narzędzie" do zapisywania pliku, a list to ten parametr co był na samej górze tej metody - lista obiektów typu Product
            serializer.Serialize(writer, list); // zapisujemy tutaj nasza liste do pliku
            writer.Close(); // zwalniamy zasoby po zapisaniu, praca skończona
        }

        // Tutaj ma miejsce to przeładowanie o którym pisałem wyżej(overload), poniżej to ta sama metoda, tylko z ciut zmienionym działaniem
        // Tutaj przyjmujemy dwa parametry, listę produktów(obiektów typu Product) oraz ścieżkę do pliku - jak się domyślasz przesyłamy do tej metody ścieżkę, którą użytkownik wcześniej określił
        // Z tej metody korzystamy za pomocą przycisku "Zapisz jako"
        private void Serialize(List<Product> list, string filePath)
        {
            // Tutaj dzieje się analogicznie jak w metodzie wyżej
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

            // Tutaj drobna różnica - zamiast currentDirectory, podajemy ścieżkę z parametru, jest to ścieżka określona przez użytkownika aplikacji
            TextWriter writer = new StreamWriter(filePath); 

            // Wszystko dzieje się analogiczne jak w metodzie wyżej
            serializer.Serialize(writer, list);
            writer.Close();
        }

        // Metody do deserializacji(odczytu) pliku .XML
        private void DeSerialize(List<Product> list)
        {
            // Do zmiennej typu string o nazwie "currentDirectory" pobieramy ścieżkę katalogu, z którego została uruchomiona aplikacja
            // tj. ta linijka: System.AppDomain.CurrentDomain.BaseDirectory
            // znakiem '+' podłączamy do niej jeszcze nazwę pliku, pozwoliłem sobie tutaj zrobić plik domyślny baza_produktow.xml i go troszkę uzupełnić produktami(obiektami typu Product)
            string currentDirectory = System.AppDomain.CurrentDomain.BaseDirectory + "baza_produktow.xml";

            // Tworzymy znów serializer, nazywamy go tylko inaczej
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Product>));

            // Tutaj jest zmiana - zamiast zapisu jest odczyt, TextWriter zmienił się na TextReader, StreamWriter na StreamReader
            TextReader reader = new StreamReader(currentDirectory); // odczytujemy plik z danej ścieżki

            if (File.Exists(currentDirectory)) // jeśli plik istnieje to...
            {
                var result = deserializer.Deserialize(reader); // odczytujemy go korzystając z "reader", wynik operacji przypisujemy do "result"
                // słówko kluczowe "var" można określic jako - nie ważne co do mnie wsadzisz ja to rozpoznam i przypisze temu typ, pewnie niektórym znajome z PHP/JS :P

                listOfProducts = (List<Product>)result; // rzutujemy to co odczytaliśmy na typ List<Product>, tak aby można go było przekazać do naszej listy produktów, tj. listOfProducts
                reader.Close(); // zwalniamy zasoby
            }
        }

        // Przeładowana metoda Deserialize przyjmująca drugi parametr tj. ścieżke podaną przez użytkownika w trakcie działania aplikacji
        private void DeSerialize(List<Product> list, string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Product>));
            TextReader reader = new StreamReader(filePath);

            // jedyne co się zmienia to to, że tym razem wykorzystywana jest ścieżka dostarczona przez użytkownika, a nie spreparowana przeze mnie jak w metodzie wyżej

            if (File.Exists(filePath)) // jeśli plik istnieje to...
            {
                var result = deserializer.Deserialize(reader); // go odczytujemy korzystając z readera, to wszystko "wsadzamy" do result
                listOfProducts = (List<Product>)result; // rzutujemy result na typ List<Product>, tak aby można go było przekazać do naszej listy produktów, tj. listOfProducts
                reader.Close(); // zwalniamy zasoby
            }
        }

        // Metoda, która jest wywoływana po naciśnięciu przycisku "Dodaj produkt", patrz event przycisku AddProduct
        private void Add()
        {
            /*
             * Teraz trochę teorii na temat wysyłania czegoś do innego okienka
             * Co się dzieje w tej metodzie? Otwiera one nowe okienko(patrz AddForm.cs) i wysyła do niego obiekt typu Product o nazwie "newProduct"
             * Dlaczego to robimy? Otóż wysłany tam nazwijmy to pusty produkt, bo taki jest w momencie wysyłania - zostaje tam zmieniony
             * Po czym wraca tutaj z powrotem - tym razem ma już swoje cechy, które użytkownik określił, jest to przykładowo gra, albo film, albo książka
             * 
             * Wysyłanie to odbywa się poprzez wysłanie tego obiektu do KONSTRUKTORA formy AddForm, o konstruktorze już było, ale być może nie pamiętasz :P
             * Konstruktor jest wywoływany podczas tworzenia obiektu, czyli jak się tworzy nową formę to do jej konstruktora wysyłamy nasz pusty produkt
             * I jest on tam odbierany i zmieniony zgodnie z wolą użytkownika - takie jest założenie tej aplikacji
             * 
             * */

            // Czyli tworzymy sobie nasz pusty produkt, tj obiekt "newProduct" typu Product(patrz Product.cs)
            Product newProduct = new Product();

            // AddForm to nic innego jak klasa, więc tak właściwie tworzymy tutaj sobie nowy obiekt tej klasy o nazwie "add" i wysyłamy do konstruktora nasz pusty produkt
            AddForm add = new AddForm(newProduct);

            // DialogResult to rezultat dialogu, czyli teraz tak: pokazujemy formę add za pomocą metody ShowDialog(), a następnie jeśli zostanie zamknięta nie wazne w jaki sposób, to rezultat
            // tego zamknięcia wróci do "result"
            DialogResult result = add.ShowDialog();
            if (result == DialogResult.OK) // jeśli zamknięcie przebiegło pomyślnie, tj. użytkownik coś tam porobił i pomyślnie zamknął okienko
            {
                // Teraz tak, ten nasz obiekt który wysłaliśmy został zmieniony, więc dodajemy go do listy obiektów typu Product
                // Dlaczego to robimy? Otóż dodajemy go tam, ponieważ ta lista jest potem zapisywana do pliku .xml
                listOfProducts.Add(newProduct);
                // Teraz tak, proszę zajrzyj do pliku Product.cs - jest to plik, który zawiera klasę Product, aby zrozumieć co tu się dzieje poniżej
                if (newProduct.Book != null) // patrzymy teraz czy jest to ksiązka
                {
                    // Tworzymy sobie ListViewItem, który jest w tym przypadku niezbędny aby dodać nasz obiekt do listy
                    // Komponent ListView nie zezwala na dodawanie customowych obiektów, np. w odróżnieniu od komponentu ListBox, który na to zezwala, jednakże ten drugi nie oferuje grup
                    ListViewItem item = new ListViewItem(); // czyli tworzymy sobie item typu ListViewItem, jest to pojedynczy element na liście
                    item.Text = newProduct.Book.Name; // ustalamy jego pola, tzn Text, czyli tak właściwie nazwę
                    item.Tag = newProduct; // Tutaj robimy małe przywiązanie, tzn. "wiążemy" ten item z obiektem, który został odebrany, możemy potem poprzez pole .Tag odnosić się do obiektu
                    books.Items.Add(item); // dodajemy nasz item do grupy books
                    ProductList.Items.Add(item); // dodajemy go do komponentu ProductList
                    ProductList.Refresh(); // odświeżamy elementy na komponencie
                }
                else if (newProduct.Video != null) // jeśli to film, wszystko dzieje się tutaj analogicznie jak wyżej
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = newProduct.Video.Name;
                    item.Tag = newProduct;
                    videos.Items.Add(item);
                    ProductList.Items.Add(item);
                    ProductList.Refresh();
                }
                else if (newProduct.Game != null) // jeśli to gra, wszystko dzieje się tutaj analogicznie jak wyżej
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = newProduct.Game.Name;
                    item.Tag = newProduct;
                    games.Items.Add(item);
                    ProductList.Items.Add(item);
                    ProductList.Refresh();
                }
            }
        }

        // Metoda, która służy do pobierania informacji o produkcie, tj. użytkownik zaznacza pozycje na liście po czym klika "Informacje o produkcie"
        private void Info()
        { // teraz tak, nie martw się, to co jest na dole tylko tak strasznie wygląda, tak na prawdę to tylko składanina tekstu
            // + łączy łańcuchy tekstowe, \n to nowa linia
            if (ProductList.SelectedItems.Count != 0) // jeśli jest coś zaznaczone na komponencie ProductList to...
            {
                string currentlySelected = ProductList.SelectedItems[0].Text; // pobiera nazwę zaznaczonego elementu na liście

                foreach (ListViewItem searching in ProductList.Items) // przeszukujemy itemy komponentu w poszukiwaniu tego co jest zaznaczone
                {
                    if (searching.Text.Equals(currentlySelected)) // jeśli go znaleźliśmy to
                    {
                        // O .Tag było już wspominane, pojedynczy element w komponencie ProductList zawiera pole .Tag, a tam informacje o obiekcie, który został do niego przydzielony
                        // czyli tworzymy sobie "getObj" typu Product i pobieramy od szukanego elementu pole .Tag rzutując je na odpowiedni typ, skasuj rzutowanie a zobaczysz co się stanie
                        Product getObj = (Product)searching.Tag;
                        // Ponieważ getObj to teraz nic innego jak obiekt, który został znaleziony, no to możemy sprawdzać czym jest, czy grą, czy filmem, czy książką
                        if (getObj.Book != null) // jeśli jest to książka to wyświetlamy odpowiedni komunikat, jest pare wariantów
                        {
                            if (!getObj.Book.IsBorrowed) // jeśli produkt nie jest wypożyczony
                            { 
                                MessageBox.Show("Nazwa książki: " + getObj.Book.Name + "\nGatunek: " + getObj.Book.Type + "\nCena: " + getObj.Book.Price.ToString() + "zł"
                                + "\nData wydania: " + getObj.Book.ReleaseDate.ToShortDateString() + "\nAutor: " + getObj.Book.Author
                                + "\nWydawnictwo: " + getObj.Book.PublishingHouse + "\nIlość stron: " + getObj.Book.NumberOfPages.ToString(),
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            // Jak widzisz w komunikacie odwołujemy się do pól obiektu, wyciągamy z niego nazwe, gatunek, cene, date, autora, itd.
                            // I za pomocą MessageBox.Show to wszystko wyświetlamy

                            else if (getObj.Book.ForAdults && getObj.Book.IsBorrowed) // kiedy produkt jest dla osób pełnoletnich i jest wypożyczony
                            {
                                MessageBox.Show("Nazwa książki: " + getObj.Book.Name + "\nGatunek: " + getObj.Book.Type + "\nCena: " + getObj.Book.Price.ToString() + "zł"
                                + "\nData wydania: " + getObj.Book.ReleaseDate.ToShortDateString() + "\nAutor: " + getObj.Book.Author
                                + "\nWydawnictwo: " + getObj.Book.PublishingHouse + "\nIlość stron: " + getObj.Book.NumberOfPages.ToString() + "\nProdukt dla osób pełnoletnich"
                                + "\nWypożyczono",
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (!getObj.Book.ForAdults && getObj.Book.IsBorrowed) // kiedy produkt nie jest dla osób pełnoletnich ale jest wypożyczony
                            {
                                MessageBox.Show("Nazwa książki: " + getObj.Book.Name + "\nGatunek: " + getObj.Book.Type + "\nCena: " + getObj.Book.Price.ToString() + "zł"
                                + "\nData wydania: " + getObj.Book.ReleaseDate.ToShortDateString() + "\nAutor: " + getObj.Book.Author
                                + "\nWydawnictwo: " + getObj.Book.PublishingHouse + "\nIlość stron: " + getObj.Book.NumberOfPages.ToString()
                                + "\nWypożyczono",
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (getObj.Video != null) // jeśli jest to film, no to dzieje się analogiczne jak wyżej, z ciut zmienionymi komunikatami
                        {
                            if (!getObj.Video.IsBorrowed) // jeśli produkt nie jest wypożyczony
                            {
                                MessageBox.Show("Nazwa filmu: " + getObj.Video.Name + "\nGatunek: " + getObj.Video.Type + "\nCena: " + getObj.Video.Price.ToString() + "zł"
                                + "\nData wydania: " + getObj.Video.ReleaseDate.ToShortDateString() + "\nReżyseria: " + getObj.Video.Direction
                                + "\nScenariusz: " + getObj.Video.Scenario,
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (getObj.Video.ForAdults && getObj.Video.IsBorrowed) // dla dorosłych i wypożyczony
                            {
                                MessageBox.Show("Nazwa filmu: " + getObj.Video.Name + "\nGatunek: " + getObj.Video.Type + "\nCena: " + getObj.Video.Price.ToString() + "zł"
                                + "\nData wydania: " + getObj.Video.ReleaseDate.ToShortDateString() + "\nReżyseria: " + getObj.Video.Direction
                                + "\nScenariusz: " + getObj.Video.Scenario + "\nWypożyczono" + "\nProdukt dla osób pełnoletnich",
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (!getObj.Video.ForAdults && getObj.Video.IsBorrowed) // dla wszystkich i wypożyczony
                            {
                                MessageBox.Show("Nazwa filmu: " + getObj.Video.Name + "\nGatunek: " + getObj.Video.Type + "\nCena: " + getObj.Video.Price.ToString() + "zł"
                                + "\nData wydania: " + getObj.Video.ReleaseDate.ToShortDateString() + "\nReżyseria: " + getObj.Video.Direction
                                + "\nScenariusz: " + getObj.Video.Scenario + "\nWypożyczono",
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else if (getObj.Game != null) // to znaczy że jest to gra! dzieje się to samo co wyżej, ciut zmienione komunikaty
                        {
                            if (!getObj.Game.IsBorrowed) // produkt wypożyczony
                            {
                                MessageBox.Show("Nazwa gry: " + getObj.Game.Name + "\nGatunek: " + getObj.Game.Type + "\nCena: " + getObj.Game.Price.ToString() + "zł"
                                + "\nData wydania: " + getObj.Game.ReleaseDate.ToShortDateString() + "\nProducent: " + getObj.Game.Producer,
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (getObj.Game.ForAdults && getObj.Game.IsBorrowed) // dla dorosłych & ktoś wypożyczył
                            {
                                MessageBox.Show("Nazwa gry: " + getObj.Game.Name + "\nGatunek: " + getObj.Game.Type + "\nCena: " + getObj.Game.Price.ToString() + "zł"
                                + "\nData wydania: " + getObj.Game.ReleaseDate.ToShortDateString() + "\nProducent: " + getObj.Game.Producer
                                + "\nWypożyczono" + "\nProdukt dla osób pełnoletnich",
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (!getObj.Game.ForAdults && getObj.Game.IsBorrowed) // dla wszystkich & ktoś wypożyczył
                            {
                                MessageBox.Show("Nazwa gry: " + getObj.Game.Name + "\nGatunek: " + getObj.Game.Type + "\nCena: " + getObj.Game.Price.ToString() + "zł"
                                + "\nData wydania: " + getObj.Game.ReleaseDate.ToShortDateString() + "\nProducent: " + getObj.Game.Producer
                                + "\nWypożyczono",
                                "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }

        }

        // Metoda, która służy do wypożyczania :)
        private void BorrowThing()
        {
            if (ProductList.SelectedItems.Count != 0) // jeśli jest coś zaznaczone w komponencie ProductList to...
            {
                string currentlySelected = ProductList.SelectedItems[0].Text; // pobiera nazwę zaznaczonego elementu na liście

                foreach (ListViewItem searching in ProductList.Items) // przeszukujemy listę w poszukiwaniu zaznaczonego elementu
                {
                    if (searching.Text.Equals(currentlySelected)) // jeśli go znaleźliśmy to
                    {
                        Product getObj = (Product)searching.Tag; // znów dzieje się .Tag, patrz metoda wyżej
                        if (getObj.Book != null) // sprawdzamy czy to obiekt typu Book
                        {
                            getObj.Book.IsBorrowed = true; // zaznaczamy wartość boolowską IsBorrowed, czyli czy wypożyczono na true
                            searching.ForeColor = Color.Red; // i zmieniamy kolor czcionki danego elementu na czerwony, tak aby było wiadomo że nie jest to produkt dostępny
                        }
                        else if (getObj.Video != null) // czy Video
                        {
                            getObj.Video.IsBorrowed = true;
                            searching.ForeColor = Color.Red;
                        }
                        else if (getObj.Game != null) // czy Game
                        {
                            getObj.Game.IsBorrowed = true;
                            searching.ForeColor = Color.Red;
                        }
                    }
                }
            }
        }

        // Zwracanie to odwrotność powyższego
        private void ReturnThing()
        {
            if (ProductList.SelectedItems.Count != 0) // jeśli jest coś zaznaczone to...
            {
                string currentlySelected = ProductList.SelectedItems[0].Text; // pobiera nazwę zaznaczonego elementu na liście

                foreach (ListViewItem searching in ProductList.Items) // przeszukujemy listę w poszukiwaniu elementu
                {
                    if (searching.Text.Equals(currentlySelected)) // jeśli go znaleźliśmy to
                    {
                        Product getObj = (Product)searching.Tag;
                        if (getObj.Book != null) // sprawdzamy czy to obiekt typu Book
                        {
                            getObj.Book.IsBorrowed = false;  // zaznaczamy wartość boolowską IsBorrowed, czyli czy wypożyczono na false
                            searching.ForeColor = Color.Black; // kolor czcionki elementu na czarny, czyli że jest dostępny
                        }
                        else if (getObj.Video != null) // czy Video
                        {
                            getObj.Video.IsBorrowed = false;
                            searching.ForeColor = Color.Black;
                        }
                        else if (getObj.Game != null) // czy Game
                        {
                            getObj.Game.IsBorrowed = false;
                            searching.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        // Kasowanie zaznaczonego elementu
        private void Delete()
        {
            if (ProductList.SelectedItems.Count != 0) // jeśli jest coś zaznaczone to...
            {
                string currentlySelected = ProductList.SelectedItems[0].Text; // pobiera nazwę zaznaczonego elementu na liście
                var delete = listOfProducts.Find(item => item.Book != null && item.Book.Name == currentlySelected
                                                || item.Game != null && item.Game.Name == currentlySelected 
                                                || item.Video != null && item.Video.Name == currentlySelected);
                // '=>' czytaj jako GDZIE, czyli:
                // listOfProducts.Find(item gdzie item.Book jest różny od null oraz item.Book.Name == currentlySelected lub item.Game jest różny od null[..]
                // czyli szukamy tego co jest zaznaczone, rezultat przypisujemy do 'delete'
                // To co tutaj zastosowaliśmy to LINQ i tak zwany lambda expression('=>')
                // LINQ to taki SQL wewnątrz C# tylko że do obiektów
                // zachęcam do googlowania ale nie byłbym sobą gdyby tego zabrakło
                if (delete != null) // jeśli 'delete' nie jest puste, to znaczy że coś zostało znalezione
                {
                    listOfProducts.Remove(delete); // usuwamy produkt z listy listOfProducts, w końcu jak coś ma być skasowane to po co to potem zapisywać do pliku?
                    ProductList.Items.Remove(ProductList.SelectedItems[0]); // kasujemy pozycję również z komponentu ProductList, niech użytkownik widzi, że tego już nie ma
                    ProductList.Refresh(); // odświeżamy komponent
                }
            }
        }

        // Przy wczytywaniu kolorujemy wypożyczone elementy w ProductList na czerwono 
        private void CodeRed()
        {
            foreach (ListViewItem searching in ProductList.Items) // przeszukujemy listę w poszukiwaniu elementu
            {
                Product getObj = (Product)searching.Tag; // o .Tag patrz metodę Info()
                if (getObj.Book != null) // sprawdzamy czy to obiekt typu Book
                {
                    if (getObj.Book.IsBorrowed) // jeśli obiekt jest wypożyczony, tj. IsBorrowed jest ustawione na true
                        searching.ForeColor = Color.Red; // no to kolorujemy czcionke na czerwono
                    ProductList.Refresh(); // i odświeżamy komponent ProductList
                }
                else if (getObj.Video != null) // czy Video
                {
                    if (getObj.Video.IsBorrowed)
                        searching.ForeColor = Color.Red;
                    ProductList.Refresh();
                }
                else if (getObj.Game != null) // czy Game
                {
                    if (getObj.Game.IsBorrowed)
                        searching.ForeColor = Color.Red;
                    ProductList.Refresh();
                }
            }
        }

        // Metoda do wypełniania komponentu ProductList
        // Czyli co tutaj się dzieje? Przechodzimy produkt po produkcie z listy listOfProducts i odp. je grupujemy i dodajemy do komponentu ProductList
        // Jest to metoda wczytująca
        private void FillList()
        {
            foreach (Product product in listOfProducts) // przeszukuje listę listOfProducts, która zawiera nasze produkty
            {
                if (product.Book != null) // patrzymy teraz czy jest to ksiązka
                {
                    // O tym co jest tutaj było już mówione, patrz metodę Add()
                    ListViewItem item = new ListViewItem();
                    item.Text = product.Book.Name;
                    item.Tag = product;
                    books.Items.Add(item);
                    ProductList.Items.Add(item);
                    ProductList.Refresh();
                }
                else if (product.Video != null) // czy wideo, wszystko dzieje się tutaj analogicznie jak wyżej
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = product.Video.Name;
                    item.Tag = product;
                    videos.Items.Add(item);
                    ProductList.Items.Add(item);
                    ProductList.Refresh();
                }
                else if (product.Game != null) // czy gra, wszystko dzieje się tutaj analogicznie jak wyżej
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = product.Game.Name;
                    item.Tag = product;
                    games.Items.Add(item);
                    ProductList.Items.Add(item);
                    ProductList.Refresh();
                }
            }
            CodeRed(); // Wywołujemy metodę CodeRed(), która służy do kolorowania wypożyczonych itemów na czerwono
        }

        #endregion

        #region NASZE OKNO

        public MainForm() // konstruktor naszego MainForm, automatycznie generowany przez IDE
        {
            InitializeComponent(); // wywołuje metodę odpowiedzalną za inicializacje komponentów na formie
        }

        #endregion

        #region NASZE ZDARZENIA

        private void MainForm_Load(object sender, EventArgs e) // zdarzenie wywoływane, gdy MainForm jest ładowane, tj. gdy nasza forma jest ładowana, przy starcie aplikacji
        {
            // Ustalamy pola utworzonych przez nas obiektów typu ListViewGroup, czyli są to nasze grupy
            books.Header = "Książki"; // nagłówek grupy
            books.HeaderAlignment = HorizontalAlignment.Left; // gdzie znajduje się nagłówek, tutaj jest po lewej stronie
            // Aby był np wycentrowany wystarczy zmienić HorizontalAlignment na Center

            games.Header = "Gry";
            games.HeaderAlignment = HorizontalAlignment.Left;

            videos.Header = "Filmy";
            videos.HeaderAlignment = HorizontalAlignment.Left;

            // Dodajemy utworzone przez nas obiekty typu ListViewGroup do naszego komponentu ProductList, tj. dodajemy grupy do komponentu, "podpinamy" je
            ProductList.Groups.Add(books);
            ProductList.Groups.Add(games);
            ProductList.Groups.Add(videos);
            // Moglibyśmy to wszystko zrobić, tj. utworzyć grupy z poziomu okna Properties Window(skrót klawiszowy F4 na [Design], ale chciałem pokazać jakby to wyglądało z poziomu kodu

            // Tutaj pobieramy ścieżkę do folderu, z którego została uruchomiona aplikacja i za pomocą '+' dopisujemy do niej plik baza_produktow.xml
            // Czyli tutaj na starcie aplikacji wczytujemy już utworzony wcześniej przeze mnie plik, który zawiera jakieś tam informacje
            string currentDirectory = System.AppDomain.CurrentDomain.BaseDirectory + "baza_produktow.xml";

            if (File.Exists(currentDirectory)) // sprawdzamy czy istnieje
            {
                try // bloki try... catch - gdy wystąpi jakiś błąd przechywci nam odpowiedni wyjątek -  co poszło nie tak - ot taka informacja dla użytkownika, aby mógł ją potem
                { // przykładowo przesłać do twórcy aplikacji, bądź też informacja dla samego developera co się "wykrzaczyło""
                    DeSerialize(listOfProducts); // wywołujemy metodę Deserialize, tutaj dokonujemy tzw. deserializacji listy, która została już wyżej wymieniona i opisana
                    FillList(); // wywołujemy metodę FillList
                }
                catch (Exception ex) // blok catch, czyli przechwytuje ewentualny wyjątek jeśli oczywiście jakiś jest, jest on zapisywany do "ex"
                {
                    MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); // wywołuje komunikat z treścią wyjątku
                }
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) // zdarzenie wywoływane, gdy MainForm jest zamykany, tzn gdy zamkamy aplikację
        {
            try // tutaj znowu bloki try...catch
            {
                Serialize(listOfProducts); // tym razem, gdy aplikacja jest zamykana zapisujemy sobię liste naszych produktów(obiektów typu Product) do pliku baza_produktow.xml
            }
            catch (Exception ex) // tutaj przechywtywany jest ewentualny wyjątek
            {
                MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); // odpowiedni komunikat
            }
        }

        private void AddProduct_Click(object sender, EventArgs e) // zdarzenie, które nastepuje po naciśnięciu przycisku "Dodaj produkt"
        {
            Add(); // wywołujemy odpowiednią metodę
        }
        private void GetInfo_Click(object sender, EventArgs e) // zdarzenie dla przycisku "Informacje o produkcie"
        {
            Info(); // wywołujemy odp metodę
        }
        private void Borrow_Click(object sender, EventArgs e) // zdarzenie gdy klikniemy przycisk "Wypożycz"
        {
            BorrowThing(); // wywołujemy metodę
        }
        private void DelProduct_Click(object sender, EventArgs e) // zdarzenie, gdy klikniemy przycisk "Usuń produkt"
        {
            Delete(); // wywołujemy metodę
        }
        private void Returned_Click(object sender, EventArgs e) // zdarzenie, gdy klikniemy przycisk "Zwróć"
        {
            ReturnThing(); // wywołujemy metodę ReturnThing()
        }

        #endregion

        #region MENU PRAWY PRZYCISK MYSZY

        private void wypożyczToolStripMenuItem_Click(object sender, EventArgs e) // PPM na ProductList -> Wypożycz
        {
            BorrowThing(); // wywołujemy metodę BorrowThing()
        }
        private void oddanoToolStripMenuItem_Click(object sender, EventArgs e) // PPM na ProductList -> Zwróć
        {
            ReturnThing(); // wywołujemy
        }
        private void usuńProduktToolStripMenuItem_Click(object sender, EventArgs e) // PPM na ProductList -> Usuń produkt
        {
            Delete(); // wywołujemy
        }
        private void ProductInfoItem_Click(object sender, EventArgs e) // PPM na ProductList -> Informacje o produkcie
        {
            Info(); // wywołujemy
        }

        #endregion

        #region GŁÓWNE MENU GÓRNE

        private void NewItem_Click(object sender, EventArgs e) // zdarzenie, gdy klikniemy "Nowy" z górnego menu Plik -> Nowy
        {
            // Nie skorzystamy poniżej z foreach, ponieważ w foreach nie można modyfikować kolekcji, można ją tylko oglądać

            for(int i = 0; i < listOfProducts.Count(); i++) // pobieramy ilość produktów z listy listOfProducts no i przechodzimy od 0 do ilości
            {
                listOfProducts.RemoveAt(i); // kasujemy pozycje pod danym indeksem
            }
            ProductList.Items.Clear(); // czyścimy komponent ProductList z wszystkich elementów
        }
        private void OpenItem_Click(object sender, EventArgs e) // gdy klikniemy Plik -> Otwórz
        {
            OpenFileDialog openFile = new OpenFileDialog(); // tworzymy sobie OpenFileDialog, czyli dialog do otwarcia pliku
            openFile.Filter = "Plik XML (*.xml)|*.xml|Wszystkie pliki (*.*)|*.*"; // nadajemy mu odpowiedni filtr, tzn jakie pliki można otworzyć i o jakim rozszerzeniu
            openFile.Title = "Otwórz listę produktów"; // nadajemy mu tytuł
            if (openFile.ShowDialog() == DialogResult.OK) // jeśli wszystko przebiegło pomyślnie, tzn plik został wybrany przez użytkownika i kliknął on "Otwórz"
            {
                try // no to blok try..catch
                {
                    DeSerialize(listOfProducts, openFile.FileName); // wykorzystujemy sobie drugi wariant metody Deserialize, użytkownik podaje nam co chce otworzyć i gdzie to się znajduje
                    ProductList.Items.Clear(); // czyścimy elementy ProductList, żeby wypełnić je nowymi
                    FillList(); // wypełniamy listę, tzn wczytujemy ją wywołując metode FillList()
                }
                catch (Exception ex) // tutaj ewentualne błędy w otwieraniu
                {
                    MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error); // i komunikat z błędem
                }
            }
        }
        private void SaveAsItem_Click(object sender, EventArgs e) // gdy klikniemy Plik -> Zapisz jako
        {
            SaveFileDialog saveFile = new SaveFileDialog(); // tworzymy dialog do zapisu pliku
            saveFile.Filter = "Plik XML (*.xml)|*.xml"; // nadajemy mu odp filtr
            saveFile.Title = "Zapisz swoją liste"; // tytuł
            if (saveFile.ShowDialog() == DialogResult.OK) // jeśli wszystko przebiegło pomyślnie to
            {
                try // znów try...catch
                {
                    Serialize(listOfProducts, saveFile.FileName); // wykorzystujemy drugi wariant Serialize, użytkownik podaje gdzie chce zapisać plik no to zapisujemy listę w odp miejsce
                } // jako plik .xml
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void CloseItem_Click(object sender, EventArgs e) // gdy klikniemy Plik -> Zamknij
        {
            this.Close(); // no to zamykamy okienko!
        }

        #endregion

    }
}
