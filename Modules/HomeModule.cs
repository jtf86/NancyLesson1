namespace FriendLetter
{
  using Nancy;
  using nancytest.Objects;

  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        var myLetterVariables = new LetterVariables {
          Recipient = "Jill",
          Sender = "John"
        };
        return View["hello.html", myLetterVariables];
      };    }
  }
}
