using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



using OpenQA.Selenium.DevTools.V104.Tracing;
// open chrome browser
IWebDriver driver = new ChromeDriver();
// Navigate to turnup portal
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
//identify username and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

//identify password and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");


// identify login button and click on it
IWebElement Login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
Login.Click();

Thread.Sleep(1000);
// check user is logged in sucessfully
//IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
//if (helloHari.Text == "Hello hari!")
//{
//    Console.WriteLine("Logged in successfully,test passed.");
//}
//else
//{
//    Console.WriteLine("Test failed1");
//    Console.WriteLine(helloHari.Text);
//   Console.WriteLine("Test failed2");
//}

//Click Admin
IWebElement Admin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
Admin.Click();
Thread.Sleep(500);

//Click TM
IWebElement TM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
TM.Click();
Thread.Sleep(500);

//Click Create  button
IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
CreateNew.Click();

//Feed code
IWebElement CodeText = driver.FindElement(By.Id("Code"));
CodeText.SendKeys("Doncode");

//Feed Desc
IWebElement DescText = driver.FindElement(By.Id("Description"));
DescText.SendKeys("DonDesc");

///Feed price
IWebElement inputTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
inputTag.Click();

IWebElement PricText = driver.FindElement(By.Id("Price"));
PricText.SendKeys("12");

//Click Save  button
IWebElement Save = driver.FindElement(By.Id("SaveButton"));
Save.Click();
Thread.Sleep(10000);


//Edit code

IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editButton.Click();
IWebElement codeTextboxEdit = driver.FindElement(By.Id("Code"));
codeTextboxEdit.Clear();
codeTextboxEdit.SendKeys("DonCode");

//click on save
driver.FindElement(By.Id("SaveButton")).Click();
Thread.Sleep(2000);
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();
Thread.Sleep(2000);
//IWebElement save = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
IWebElement save = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

if (save.Text == "Doncode")
{
    Console.WriteLine("Code edited successfully");
}
else
{
    Console.WriteLine("Code edit Failed"); ;
}


//Delete code

IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
DeleteButton.Click();
Thread.Sleep(2000);
IAlert alert = driver.SwitchTo().Alert();
alert.Accept();
Thread.Sleep(2000);
driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span")).Click();

Thread.Sleep(2000);
//IWebElement Delete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

IWebElement Delete = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[5]/a[2]"));
if (Delete.Text == "Doncode")
{
    Console.WriteLine("Found record");
}
else
{
    Console.WriteLine("record deleted ");
}
