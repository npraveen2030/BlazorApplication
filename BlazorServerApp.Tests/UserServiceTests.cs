using BlazorServerApp.BLL.Service;
using BlazorServerApp.DLL.Interface;
using BlazorServerApp.Model.EntityModel;
using Moq;
using NUnit.Framework;

namespace BlazorServerApp.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private Mock<IUserRepository> _mockRepo = null!;
        private UserService _service = null!;

        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IUserRepository>();
            _service = new UserService(_mockRepo.Object);
        }

        [Test]
        public async Task AddAsync_CallsRepository()
        {
            var user = new User { Name = "John", Email = "john@example.com" };
            await _service.AddUserAsync(user);
            _mockRepo.Verify(r => r.AddAsync(user), Times.Once);
        }

        [Test]
        public async Task UpdateAsync_CallsRepository()
        {
            var user = new User { Id = 1, Name = "Updated", Email = "updated@example.com" };
            await _service.UpdateUserAsync(user);
            _mockRepo.Verify(r => r.UpdateAsync(user), Times.Once);
        }

        [Test]
        public async Task DeleteAsync_CallsRepository()
        {
            await _service.DeleteUserAsync(1);
            _mockRepo.Verify(r => r.DeleteAsync(1), Times.Once);
        }

        [Test]
        public async Task GetAllAsync_ReturnsUserList()
        {
            _mockRepo.Setup(r => r.GetAllAsync()).ReturnsAsync(new List<User> { new() { Id = 1 } });
            var users = await _service.GetAllUsersAsync();
            Assert.That(1, Is.EqualTo(users.Count));
        }

        [Test]
        public async Task GetByIdAsync_ReturnsUser()
        {
            var user = new User { Id = 1, Name = "Test" };
            _mockRepo.Setup(r => r.GetByIdAsync(1)).ReturnsAsync(user);
            var result = await _service.GetUserByIdAsync(1);
            Assert.That("Test", Is.EqualTo(result?.Name));
        }

        //private AppDbContext _context = null!;
        //private UserService _service = null!;

        //[SetUp]
        //public void Setup()
        //{
        //    var options = new DbContextOptionsBuilder<AppDbContext>()
        //        .UseInMemoryDatabase(databaseName: "TestDb")
        //        .Options;

        //    _context = new AppDbContext(options);
        //    _context.Users.AddRange(
        //        new User { Id = 1, Name = "Alice", Email = "alice@example.com" },
        //        new User { Id = 2, Name = "Bob", Email = "bob@example.com" }
        //    );
        //    _context.SaveChanges();

        //    _service = new UserService(_context);
        //}

        //[Test]
        //public async Task GetAllAsync_ReturnsAllUsers()
        //{
        //    var result = await _service.GetAllUsersAsync();
        //    Assert.AreEqual(2, result.Count);
        //}

        //[Test]
        //public async Task AddAsync_AddsNewUser()
        //{
        //    var user = new User { Name = "Charlie", Email = "charlie@example.com" };
        //    await _service.AddUserAsync(user);

        //    var result = await _service.GetAllUsersAsync();
        //    Assert.AreEqual(3, result.Count);
        //}

        //[Test]
        //public async Task DeleteAsync_RemovesUser()
        //{
        //    await _service.DeleteUserAsync(1);
        //    var result = await _service.GetAllUsersAsync();
        //    Assert.AreEqual(1, result.Count);
        //}
    }
}