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
          Recipient = "Jessica"
        };
        return View["hello.html", myLetterVariables];
      };    }
  }
}
