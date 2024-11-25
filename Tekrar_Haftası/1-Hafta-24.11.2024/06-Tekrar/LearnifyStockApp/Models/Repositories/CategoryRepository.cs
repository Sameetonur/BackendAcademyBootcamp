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

    /// <summary>
    /// Tüm Kategorileri Döndürür.
    /// </summary>
    /// <returns></returns>
    public async Task<IEnumerable<CategoryViewModel>> GetAllAsync()
    {
        string query = "Select * From Categories";
        return await _dbConnection.QueryAsync<CategoryViewModel>(query);
    }

    /// <summary>
    /// Silinmiş ya da silinmemiş tüm kategorileri döndürür.
    /// </summary>
    /// <param name="isDeleted"> SİLİNMİŞ KATEGORİLER İÇİN TRUE SİLİNMEMİŞ İÇİN FALSE DÖNDÜRÜR.</param>
    /// <returns></returns>
    public async Task<IEnumerable<Category>> GetAllAsync(bool isDeleted)
    {
        string query = "SELECT * FFROM  Categories WHERE IsDeleted=@IsDeleted ";
        return await _dbConnection.QueryAsync<Category>(query, new
        {
            IsDeleted = isDeleted
        });
    }

    /// <summary>
    /// ID Sİ VERİLEN KATEGORİ BİLGİSİNİ DÖNDÜRÜR.
    /// </summary>
    /// <param name="id">DÖNÜDRMEK İSTENEN KATEGORİSİNİN ID SİNİ DÖNDÜRÜR.</param>
    /// <returns></returns>

    public async Task<Category?> GetAsync(int id)
    {
        string query = "SELECT * FFROM Categories WHERE Id=@Id";

        return await _dbConnection.QueryFirstOrDefaultAsync<Category>(query, new { Id = id });
    }

    /// <summary>
    /// YENİ KATEGORİ EKLER
    /// </summary>
    /// <param name="category">YENİ EKLENEN KATEGORİ BİLGİSİ</param>
    /// <returns></returns>
    public async Task AddAsync(AddCategoryViewModel category)
    {
        string query = "INSERT INTO Categories(Name,Description) VALUES (@Name,@Description)";
        await _dbConnection.ExecuteAsync(query, category);
    }

    /// <summary>
    /// KATEGORİYİ GÜNCELLER
    /// </summary>
    /// <param name="category">GÜNCELLENECEK KATEGORİ BİLGİSİ</param>
    /// <returns></returns>

    public async Task UpdateAsync(UpdateCategoryViewModel category)
    {
        string query = "UPDATE Categories SET Name=@Name, Description=@Description, IsDeleted=@IsDeleted WHERE Id=@Id ";
        await _dbConnection.ExecuteAsync(query, category);
    }

    /// <summary>
    /// ID'Sİ VERİLEN KATEGORİYİ VERİ TABANINDAN KALICI OLARAK SİLER.
    /// </summary>
    /// <param name="id">SİLİNECEK KATEGORİNİN İD'SİNİ DÖNER</param>
    /// <returns></returns>
    public async Task HardDeleteAync(int id)
    {
        string query = "DELETE Categories WHERE Id=@Id";
        await _dbConnection.ExecuteAsync(query, new { Id = id });
    }

    /// <summary>
    /// ID'Sİ VERİLEN KATEGORİNİN ÇÖP KUTUSUNA ATILMASINI SAĞLAR.
    /// </summary>
    /// <param name="id">SİLİNECEK KATEGORİNİN İD'SİNİN BİLGİSİ</param>
    /// <returns></returns>

    public async Task SoftDeleteAync(int id)
    {
        var category = await GetAsync(id);
        var isDeleted = !category.IsDeleted;

        string query = "UPDATE Categories SET IsDeleted =@IsDeleted WHERE Id=@Id";
        await _dbConnection.ExecuteAsync(query, new { Id = id, IsDeleted = isDeleted });
    }

    /// <summary>
    /// EN ÇOK SATIŞ YAPILAN KATEGORİ ADINI VE SATIŞ TUTARINI DÖNDÜRÜR.
    /// </summary>
    /// <returns></returns>
    public async Task<(string CategoryName, decimal TotalSales)> GetTopSellingCategoryAsync()
    {
        string query = @"
                SELECT TOP (1)
        c.Name as CategoryName,
            SUM(s.Quantity*s.UnitPrice) AS TotalSales
        FROM Categories c 
            JOIN Products p on c.Id=p.CategoryId
            JOIN Sales s on p.Id=s.ProductId
            GROUP BY c.Name
            ORDER BY SUM
            (s.Quantity*s.UnitPrice) DESC
        ";
        return await _dbConnection.QueryFirstOrDefaultAsync<(string CategoryName, decimal TotalSales)>(query);


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