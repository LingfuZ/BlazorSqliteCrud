namespace Employee.pages
{
    public partial class Index
    {
        public bool ShowCreate ( get; set; )

        private EmployeeDataContext? _context;
        public Employee NewEmployee ( get; set; )

        public List<Employee> CurrentEmployees ( get; set; )

        protected override async Task OnInitializedAsync()
        {
            ShowCreate = false;
            await ShowEmployees();
        }

        public void ShowCreateForm()
        {
            ShowCreate = true;
            NewEmployee = new Employee();
        }

        public async Task CreateNewEmployee()
        {
            _context ??= await EmployeeDataContextFactory.CreateDbContextAsync();

            if (NewEmployee is not null)
            {
                _context?.Employees.Add();
                _context?.SaveChangeAsync();
            }

            ShowCreate = false;
        }

        public async Task ShowEmployees()
        {
            _context ??= await EmpoyeeDataContextFactory.CreateDbContextAsync();

            if (_context is not null)
            {
                OurEmployees = await _context.Employees.ToListAsync();
            }

            if (_context is not null) await _context.DisposeAsync();
        }
    }
}