namespace FriendLetter
{
  using Nancy;
  using nancytest.Objects;

  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => View["form.html"];
      Get["/"] = _ => {
        var myLetterVariables = new LetterVariables {
          Recipient = "Jill",
          Sender = "John"
        };
        return View["hello.html", myLetterVariables];
      };
      Get["/greeting_card"] = _ => {
        var myLetterVariables = new LetterVariables {
          Sender = Request.Query["sender"],
          Recipient = Request.Query["recipient"]
        };
        return View["hello.html", myLetterVariables];
      };
    }
  }
}
