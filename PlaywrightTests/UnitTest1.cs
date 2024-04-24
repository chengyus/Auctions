using Microsoft.Playwright.NUnit;

namespace PlaywrightTests;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class MyEndToEndTestSuite : PageTest
{
  [Test]
  public async Task ShouldHaveCopyrightLine()
  {
    await Page.GotoAsync("https://localhost:7106");
    await Expect(Page.Locator("text=© 2024 - Auctions")).ToBeVisibleAsync();
  }

  [Test]
  public async Task ShouldHaveTheCorrectTitle()
  {
    await Page.GotoAsync("https://localhost:7106");
    //ref video: https://youtu.be/QDkKmiyULu4, luckily there is an Async version.
    await Expect(Page).ToHaveTitleAsync("Index - Auctions");
  }
}