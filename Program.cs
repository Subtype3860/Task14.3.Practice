namespace Task14._3.Practice
{
    class Program
    {
        public static void Main()
        {
            // добавляем контакты
            var phoneBook = new List<Contact>
            {
                new ("Игорь", "Николаев", 79990000001, "igor@example.com"),
                new ("Сергей", "Довлатов", 79990000010, "serge@example.com"),
                new ("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
                new ("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
                new ("Сергей", "Брин", 799900000013, "serg@example.com"),
                new ("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
            };

            //Сортировка
            var pb = phoneBook.OrderBy(order => order.Name).ThenBy(thenby => thenby.LastName);

            //Вывод списка
            foreach (var i in pb)
            {
                Console.WriteLine($"Имя: {i.Name}\tФамилия: {i.LastName}\n\tТелефон: {i.PhoneNumber}\n\tE-mail: {i.Email}");
            }
        }
    }
}
