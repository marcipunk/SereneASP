namespace SereneASP.Cobrademo {
    export class AccountForm extends Serenity.PrefixedContext {
        static formKey = 'Cobrademo.Account';

    }

    export interface AccountForm {
        Code: Serenity.StringEditor;
        TaxYearId: Serenity.IntegerEditor;
        TreasuryAccountId: Serenity.IntegerEditor;
        AncestorAccountId: Serenity.IntegerEditor;
        ParentAccountId: Serenity.IntegerEditor;
        Placeholder: Serenity.BooleanEditor;
        TaxRelated: Serenity.BooleanEditor;
        Hidden: Serenity.BooleanEditor;
        TransactionAccountId: Serenity.IntegerEditor;
        IsCollectorExpected: Serenity.BooleanEditor;
        ParallelAccountId: Serenity.IntegerEditor;
        LayerId: Serenity.EnumEditor;
        IsPartnerExpected: Serenity.BooleanEditor;
    }

    [['Code', () => Serenity.StringEditor], ['TaxYearId', () => Serenity.IntegerEditor], ['TreasuryAccountId', () => Serenity.IntegerEditor], ['AncestorAccountId', () => Serenity.IntegerEditor], ['ParentAccountId', () => Serenity.IntegerEditor], ['Placeholder', () => Serenity.BooleanEditor], ['TaxRelated', () => Serenity.BooleanEditor], ['Hidden', () => Serenity.BooleanEditor], ['TransactionAccountId', () => Serenity.IntegerEditor], ['IsCollectorExpected', () => Serenity.BooleanEditor], ['ParallelAccountId', () => Serenity.IntegerEditor], ['LayerId', () => Serenity.EnumEditor], ['IsPartnerExpected', () => Serenity.BooleanEditor]].forEach(x => Object.defineProperty(AccountForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

