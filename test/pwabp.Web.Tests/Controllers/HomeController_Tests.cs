using System.Threading.Tasks;
using pwabp.Models.TokenAuth;
using pwabp.Web.Controllers;
using Shouldly;
using Xunit;

namespace pwabp.Web.Tests.Controllers
{
    public class HomeController_Tests: pwabpWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}