namespace Lab.Data
{
    public class SeedData
    {
        public async Task InitialyzeAsync(StipContext context)
        {
            var students = new Student[]
                {

                };
            context.students.AddRange(students);
            await context.SaveChangesAsync();
        }
    }
}
