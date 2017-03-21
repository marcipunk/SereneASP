namespace SereneASP.Cobrademo {
    export class AccountSheetCoreForm extends Serenity.PrefixedContext {
        static formKey = 'Cobrademo.AccountSheetCore';

    }

    export interface AccountSheetCoreForm {
        TaxYearId: Serenity.IntegerEditor;
        LayerId: Serenity.IntegerEditor;
        AccountId: Serenity.IntegerEditor;
        BookingDate: Serenity.DateEditor;
        CompletionDate: Serenity.DateEditor;
        TabletypeId: Serenity.IntegerEditor;
        FileId: Serenity.IntegerEditor;
        FileAvatarId: Serenity.IntegerEditor;
        FileGeneratedSign: Serenity.StringEditor;
        FileUserSign: Serenity.StringEditor;
        OrdinalNumber: Serenity.IntegerEditor;
        SrcAvatarId: Serenity.IntegerEditor;
        LedgerItemId: Serenity.IntegerEditor;
        ItemTypeId: Serenity.IntegerEditor;
        SrcFinanceLinkId: Serenity.IntegerEditor;
        EventTypeId: Serenity.IntegerEditor;
        PartnerId: Serenity.IntegerEditor;
        ReferenceNumber: Serenity.IntegerEditor;
        VoucherNum: Serenity.StringEditor;
        LedgerCurrencyId: Serenity.StringEditor;
        LedgerRate: Serenity.DecimalEditor;
        LedgerName: Serenity.StringEditor;
        LedgerItemCurrencyId: Serenity.StringEditor;
        LedgerItemRate: Serenity.DecimalEditor;
        LedgerItemName: Serenity.StringEditor;
        Side: Serenity.IntegerEditor;
        OriginalAmount: Serenity.DecimalEditor;
        Amount: Serenity.DecimalEditor;
        OriginalDebitAmount: Serenity.DecimalEditor;
        OriginalCreditAmount: Serenity.DecimalEditor;
        DebitAmount: Serenity.DecimalEditor;
        CreditAmount: Serenity.DecimalEditor;
        AccountCode: Serenity.StringEditor;
        ContraAccounts: Serenity.StringEditor;
        IsFinalized: Serenity.BooleanEditor;
        IsActive: Serenity.BooleanEditor;
        AccountInTaxYear: Serenity.BooleanEditor;
        AccountInLayer: Serenity.BooleanEditor;
        BookingDateInTaxYear: Serenity.BooleanEditor;
        IsCurrent: Serenity.BooleanEditor;
    }

    [['TaxYearId', () => Serenity.IntegerEditor], ['LayerId', () => Serenity.IntegerEditor], ['AccountId', () => Serenity.IntegerEditor], ['BookingDate', () => Serenity.DateEditor], ['CompletionDate', () => Serenity.DateEditor], ['TabletypeId', () => Serenity.IntegerEditor], ['FileId', () => Serenity.IntegerEditor], ['FileAvatarId', () => Serenity.IntegerEditor], ['FileGeneratedSign', () => Serenity.StringEditor], ['FileUserSign', () => Serenity.StringEditor], ['OrdinalNumber', () => Serenity.IntegerEditor], ['SrcAvatarId', () => Serenity.IntegerEditor], ['LedgerItemId', () => Serenity.IntegerEditor], ['ItemTypeId', () => Serenity.IntegerEditor], ['SrcFinanceLinkId', () => Serenity.IntegerEditor], ['EventTypeId', () => Serenity.IntegerEditor], ['PartnerId', () => Serenity.IntegerEditor], ['ReferenceNumber', () => Serenity.IntegerEditor], ['VoucherNum', () => Serenity.StringEditor], ['LedgerCurrencyId', () => Serenity.StringEditor], ['LedgerRate', () => Serenity.DecimalEditor], ['LedgerName', () => Serenity.StringEditor], ['LedgerItemCurrencyId', () => Serenity.StringEditor], ['LedgerItemRate', () => Serenity.DecimalEditor], ['LedgerItemName', () => Serenity.StringEditor], ['Side', () => Serenity.IntegerEditor], ['OriginalAmount', () => Serenity.DecimalEditor], ['Amount', () => Serenity.DecimalEditor], ['OriginalDebitAmount', () => Serenity.DecimalEditor], ['OriginalCreditAmount', () => Serenity.DecimalEditor], ['DebitAmount', () => Serenity.DecimalEditor], ['CreditAmount', () => Serenity.DecimalEditor], ['AccountCode', () => Serenity.StringEditor], ['ContraAccounts', () => Serenity.StringEditor], ['IsFinalized', () => Serenity.BooleanEditor], ['IsActive', () => Serenity.BooleanEditor], ['AccountInTaxYear', () => Serenity.BooleanEditor], ['AccountInLayer', () => Serenity.BooleanEditor], ['BookingDateInTaxYear', () => Serenity.BooleanEditor], ['IsCurrent', () => Serenity.BooleanEditor]].forEach(x => Object.defineProperty(AccountSheetCoreForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

