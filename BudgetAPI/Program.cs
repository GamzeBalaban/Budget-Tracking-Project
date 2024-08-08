
using AutoMapper;
using BudgetTracking.BusinessLayer.Abstract;
using BudgetTracking.BusinessLayer.Concrete;
using BudgetTracking.DataAccessLayer.Abstract;
using BudgetTracking.DataAccessLayer.Concreate;
using BudgetTracking.DataAccessLayer.EntityFramework;
using ButceTracking.BusinessLayer.Concrete;
using ButceTracking.DataAccessLayer.EntityFramework;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BudgetContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());



builder.Services.AddScoped<IAppControlService, AppControlManager>();
builder.Services.AddScoped<IAppControlDal, EfAppControlDal>();

builder.Services.AddScoped<IRolesService, RolesManager>();
builder.Services.AddScoped<IRolesDal, EfRolesDal>();


builder.Services.AddScoped<IExpensesService, ExpensesManager>();
builder.Services.AddScoped<IExpensesDal, EfExpensesDal>();

builder.Services.AddScoped<IWorkDoneService, WorkDoneManager>();
builder.Services.AddScoped<IWorkDoneDal, EfWorkDoneDal>();

builder.Services.AddScoped<IWorkDoneTypeService, WorkDoneTypeManager>();
builder.Services.AddScoped<IWorkDoneTypeDal, EfWorkDoneTypeDal>();

builder.Services.AddScoped<IVATService, VATManager>();
builder.Services.AddScoped<IVATDal, EfVATDal>();

builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IUserDal, EfUserDal>();

builder.Services.AddScoped<ILevelService, LevelsManager>();
builder.Services.AddScoped<ILevelDal, EfLevelDal>();

builder.Services.AddScoped<IRefuseService, RefuseManager>();
builder.Services.AddScoped<IRefuseDal, EfRefuseDal>();



builder.Services.AddScoped<ISubLevelService, SubLevelsManager>();
builder.Services.AddScoped<ISubLevelDal, EfSubLevelDal>();

builder.Services.AddScoped<ICompanyNameService, CompanyNameManager>();
builder.Services.AddScoped<ICompanyNameDal, EfCompanyNameDal>();



builder.Services.AddScoped<IBudgetService, BudgetManager>();
builder.Services.AddScoped<IBudgetDal, EfBudgetDal>();



builder.Services.AddScoped<IPlanningService, PlanningManager>();
builder.Services.AddScoped<IPlanningDal, EfPlanningDal>();


builder.Services.AddScoped<IRealizationService, RealizationManager>();
builder.Services.AddScoped<IRealizationDal, EfRealizationDal>();


builder.Services.AddScoped<IApprovalService, ApprovalManager>();
builder.Services.AddScoped<IApprovalDal, EfApprovalDal>();

builder.Services.AddScoped<IBudgetAmountService, BudgetAmountManager>();
builder.Services.AddScoped<IBudgetAmountDal, EfBudgetAmountDal>();





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

