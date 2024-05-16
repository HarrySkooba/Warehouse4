﻿using Backend.DB;

namespace Backend
{
    public interface IUserService
    {
        User GetUserByLogin(string username, string password);
        Role GetRoleByLogin(int idrole);

        List<User> GetAllUser();
        List<Role> GetAllRole();
        List<Product> GetAllProduct();
        List<Provider> GetAllProvider();
        List<Client> GetAllClient();

        void DeleteUser(int userId);
        void DeleteRole(int roleId);
        void DeleteProduct(int productId);
        void DeleteProvider(int providerId);
        void DeleteClient(int clientId);

        Task AddUser(User newUser);
        Task AddRole(Role newRole);
        Task AddProduct(Product newProduct);
        Task AddProvider(Provider newProvider);
        Task AddClient(Client newClient);

        Task UpdateUser(User updatedUser, int userId);
        Task UpdateRole(Role updatedRole, int roleId);
        Task UpdateProduct(Product updatedProduct, int productId);
        Task UpdateProvider(Provider updatedProvider, int providerId);
        Task UpdateClient(Client updatedClient, int clientId);
    }
}
