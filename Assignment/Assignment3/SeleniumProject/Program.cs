IDriver page1 = new AboutUsPage("about-us", [9861286]);
Console.WriteLine(page1.InitiatePhone("9861286313"));
Console.WriteLine(page1.InitiateEmail("rozengoza22@gmail.com"));
Console.WriteLine(page1.HandleMenuClick("contact-us"));
Console.WriteLine($"Navigating user to  page {page1.Navigate("contact-us")}");
Console.WriteLine(page1.Login("rozengoza22", "password@123"));
