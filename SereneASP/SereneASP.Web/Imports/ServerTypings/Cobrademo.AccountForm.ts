

namespace SereneASP.Cobrademo {
    export class AccountForm extends Serenity.PrefixedContext {
        static formKey = 'Cobrademo.Account';
    }

    export interface AccountForm {
        AvatarId: Serenity.IntegerEditor;
        Timestamp: Serenity.StringEditor;
        TreasuryAccountId: Serenity.IntegerEditor;
        TaxYearId: Serenity.IntegerEditor;
        AncestorAccountId: Serenity.IntegerEditor;
        ParentAccountId: Serenity.IntegerEditor;
        Code: Serenity.StringEditor;
        Placeholder: Serenity.BooleanEditor;
        TaxRelated: Serenity.BooleanEditor;
        Hidden: Serenity.BooleanEditor;
        TypeId: Serenity.IntegerEditor;
        TransactionAccountId: Serenity.IntegerEditor;
        IsCollectorExpected: Serenity.BooleanEditor;
        ParallelAccountId: Serenity.IntegerEditor;
        LayerId: Serenity.IntegerEditor;
        IsPartnerExpected: Serenity.BooleanEditor;
    }

    [['AvatarId', () => Serenity.IntegerEditor], ['Timestamp', () => Serenity.StringEditor], ['TreasuryAccountId', () => Serenity.IntegerEditor], ['TaxYearId', () => Serenity.IntegerEditor], ['AncestorAccountId', () => Serenity.IntegerEditor], ['ParentAccountId', () => Serenity.IntegerEditor], ['Code', () => Serenity.StringEditor], ['Placeholder', () => Serenity.BooleanEditor], ['TaxRelated', () => Serenity.BooleanEditor], ['Hidden', () => Serenity.BooleanEditor], ['TypeId', () => Serenity.IntegerEditor], ['TransactionAccountId', () => Serenity.IntegerEditor], ['IsCollectorExpected', () => Serenity.BooleanEditor], ['ParallelAccountId', () => Serenity.IntegerEditor], ['LayerId', () => Serenity.IntegerEditor], ['IsPartnerExpected', () => Serenity.BooleanEditor]].forEach(x => Object.defineProperty(AccountForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}