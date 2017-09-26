public ActionResult About()  
{  
    ViewBag.Message = "Your application description page.";  
    List<Country> objCountry = new List<Country>();  
    CountryModel model = new CountryModel();  
    objCountry = model.GetCountries();  
    return View(new Venue { Countries = objCountry });  
}  
