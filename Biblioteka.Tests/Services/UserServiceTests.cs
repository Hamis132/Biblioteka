using System.Threading.Tasks;
using AutoMapper;
using Biblioteka.Core.Domain;
using Biblioteka.Core.Repositories;
using Biblioteka.Infrastructure.Services;
using FluentAssertions;
using Moq;
using Xunit;

namespace Biblioteka.Tests.Services
{
    public class UserServiceTests
    {
        [Fact]

        public async Task register_async_should_invoke_add_async_on_repository()
        {
            var userRepositoryMock = new Mock<IUserRepository>();
            var mapperMock = new Mock<IMapper>();

            var userService = new UserService(userRepositoryMock.Object, mapperMock.Object);
            await userService.RegisterAsync("user@email.com","user","secret");

            userRepositoryMock.Verify(x => x.AddAsync(It.IsAny<User>()), Times.Once);
        }

    }
}