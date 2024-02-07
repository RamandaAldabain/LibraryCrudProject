using System.Threading.Tasks;
using CrudProject.Models.TokenAuth;
using CrudProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace CrudProject.Web.Tests.Controllers
{
    public class HomeController_Tests: CrudProjectWebTestBase
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