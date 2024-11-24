using System;
using System.Data;
using Dapper;
using LearnifyStockApp.Models.Entities;
using LearnifyStockApp.Models.ViewModels.CategoryViewModels;

namespace LearnifyStockApp.Models.Repositories;

public class CategoryRepository
{
    private readonly IDbConnection _dbConnection;
    public CategoryRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }


    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        string query= "Select * From Categories";
        return await _dbConnection.QueryAsync<Category>(query);
    }

    public async Task<IEnumerable<Category>> GetAllAsync( bool isDeleted)
    {
       string query = "Select * From Categories where IsDeleted=@IsDeleted ";
            return await _dbConnection.QueryAsync<Category>(query, new{
                IsDeleted = isDeleted
            });
    }

    public async Task<Category?> GetAsync(int id)
    {
        string query="Select * From Categories where Id=@Id";
         
        return await _dbConnection.QueryFirstOrDefaultAsync<Category>(query, new {Id=id});
    }

    public async Task AddAsync(AddCategoryViewModel category)
    {
        string query = "Insert Into Categories(Name,Description) Values (@Name,@Description)";
        await _dbConnection.ExecuteAsync(query,category);
    }







































    // public async Task<IEnumerable<Category>> GetAllAsync(bool? isDeleted=null)
    // {
    //     string query;
    //     if(isDeleted ==null)
    //     {
    //         query = "Select * From Categories";
    //         return await _dbConnection.QueryAsync<Category>(query);
    //     }
    //     query = "Select * From Categories where IsDeleted=@IsDeleted ";
    //     return await _dbConnection.QueryAsync<Category>(query, new{
    //         IsDeleted = isDeleted
    //     });


} 




























}
