namespace SereneASP.Cobrademo {
    export class TaxYearForm extends Serenity.PrefixedContext {
        static formKey = 'Cobrademo.TaxYear';

    }

    export interface TaxYearForm {
        Timestamp: Serenity.StringEditor;
        ParentTaxYearId: Serenity.IntegerEditor;
        CurrencyId: Serenity.StringEditor;
        TaxCurrencyId: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        YearNum: Serenity.IntegerEditor;
        StartDate: Serenity.DateEditor;
        EndDate: Serenity.DateEditor;
        VoucherFormat: Serenity.IntegerEditor;
        VoucherDigits: Serenity.IntegerEditor;
        VoucherSepFirst: Serenity.StringEditor;
        VoucherSepLast: Serenity.StringEditor;
        ReferenceNumFormat: Serenity.IntegerEditor;
        ReferenceNumDigits: Serenity.IntegerEditor;
        ReferenceNumSepFirst: Serenity.StringEditor;
        ReferenceNumSepLast: Serenity.StringEditor;
        IsClosed: Serenity.BooleanEditor;
        CurrencyEvaluationMode: Serenity.IntegerEditor;
        CurrencyExchangeType: Serenity.IntegerEditor;
        SalesExchanceType: Serenity.IntegerEditor;
        BookingExchangeType: Serenity.IntegerEditor;
        StockEvaluationMode: Serenity.IntegerEditor;
        FinanceLockDate: Serenity.DateEditor;
        ParallelBooking: Serenity.BooleanEditor;
        LedgerRounding: Serenity.BooleanEditor;
        SecondaryAccountAllowed: Serenity.BooleanEditor;
        BankTransactionBooking: Serenity.BooleanEditor;
        CashAccounting: Serenity.BooleanEditor;
        LedgerItemCollectorToSecondaryAccount: Serenity.BooleanEditor;
        LedgerRoundingThresholdAmount: Serenity.DecimalEditor;
        ApplyFinenceLockToStock: Serenity.BooleanEditor;
        CashAccountingVatCarryOver: Serenity.BooleanEditor;
        VatOffPeriodTransfer: Serenity.BooleanEditor;
        VatRateDifferenceTransfer: Serenity.BooleanEditor;
        VoucherShortYearNumber: Serenity.BooleanEditor;
        ReferenceShortYearNumber: Serenity.BooleanEditor;
    }

    [['Timestamp', () => Serenity.StringEditor], ['ParentTaxYearId', () => Serenity.IntegerEditor], ['CurrencyId', () => Serenity.StringEditor], ['TaxCurrencyId', () => Serenity.StringEditor], ['Name', () => Serenity.StringEditor], ['YearNum', () => Serenity.IntegerEditor], ['StartDate', () => Serenity.DateEditor], ['EndDate', () => Serenity.DateEditor], ['VoucherFormat', () => Serenity.IntegerEditor], ['VoucherDigits', () => Serenity.IntegerEditor], ['VoucherSepFirst', () => Serenity.StringEditor], ['VoucherSepLast', () => Serenity.StringEditor], ['ReferenceNumFormat', () => Serenity.IntegerEditor], ['ReferenceNumDigits', () => Serenity.IntegerEditor], ['ReferenceNumSepFirst', () => Serenity.StringEditor], ['ReferenceNumSepLast', () => Serenity.StringEditor], ['IsClosed', () => Serenity.BooleanEditor], ['CurrencyEvaluationMode', () => Serenity.IntegerEditor], ['CurrencyExchangeType', () => Serenity.IntegerEditor], ['SalesExchanceType', () => Serenity.IntegerEditor], ['BookingExchangeType', () => Serenity.IntegerEditor], ['StockEvaluationMode', () => Serenity.IntegerEditor], ['FinanceLockDate', () => Serenity.DateEditor], ['ParallelBooking', () => Serenity.BooleanEditor], ['LedgerRounding', () => Serenity.BooleanEditor], ['SecondaryAccountAllowed', () => Serenity.BooleanEditor], ['BankTransactionBooking', () => Serenity.BooleanEditor], ['CashAccounting', () => Serenity.BooleanEditor], ['LedgerItemCollectorToSecondaryAccount', () => Serenity.BooleanEditor], ['LedgerRoundingThresholdAmount', () => Serenity.DecimalEditor], ['ApplyFinenceLockToStock', () => Serenity.BooleanEditor], ['CashAccountingVatCarryOver', () => Serenity.BooleanEditor], ['VatOffPeriodTransfer', () => Serenity.BooleanEditor], ['VatRateDifferenceTransfer', () => Serenity.BooleanEditor], ['VoucherShortYearNumber', () => Serenity.BooleanEditor], ['ReferenceShortYearNumber', () => Serenity.BooleanEditor]].forEach(x => Object.defineProperty(TaxYearForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

