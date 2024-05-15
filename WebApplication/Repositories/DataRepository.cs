using Dapper;
using System.Xml.Linq;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Repositories
{
    public class DataRepository : IData
    {
        private readonly DapperDbContext context;

        public DataRepository(DapperDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<DataModel>> Get()
        {
            var sql = $@"SELECT id, name, gender, nationality, education, skills, experience FROM data";
            using var connection = context.CreateConnection();
            return await connection.QueryAsync<DataModel>(sql);
        }
        public async Task<DataModel> Find(string Id)
        {
            var sql = $@"SELECT id, name, gender, nationality, education, skills, experience FROM data where id=@Id";

            using var connection = context.CreateConnection();
            return await connection.QueryFirstOrDefaultAsync<DataModel>(sql, new { Id });
        }
        public async Task<DataModel> Add(DataModel model)
        {
            model.Id = Guid.NewGuid().ToString();
            var sql = $@"INSERT INTO data(id, name, gender, nationality, education, skills, experience) VALUES (@Id, @Name, @Gender, @Nationality, @Education, @Skills, @Experience)";

            using var connection = context.CreateConnection();
            await connection.ExecuteAsync(sql, model);
            return model;
        }
        public async Task<DataModel> Update(DataModel model)
        {
            var sql = $@"UPDATE data SET id=@Id, name=@Name, gender=@Gender, nationality=@nationality, education=@education, skills=@Skills, experience=@Experience WHERE id=@Id";
            using var connection = context.CreateConnection();
            await connection.ExecuteAsync(sql, model);
            return model;
        }
        public async Task<DataModel> Remove(DataModel model)
        {
            var sql = $@"
                        DELETE FROM
                            data
                        WHERE
                            id=@Id";
            using var connection = context.CreateConnection();
            await connection.ExecuteAsync(sql, model);
            return model;
        }
    }
}
