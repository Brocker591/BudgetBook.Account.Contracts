namespace BudgetBook.Account.Contracts
{
    public record UserBankAccountChange(
        Guid UserId,
        decimal BankAccountChange
        );
}