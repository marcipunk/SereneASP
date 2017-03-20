
namespace SereneASP.Cobrademo {
    export interface AccountNameRow {
        AccountId?: number;
        LanguageId?: string;
        Value?: string;
        Note?: string;
        AccountAvatarId?: number;
        AccountTimestamp?: number[];
        AccountTreasuryAccountId?: number;
        AccountTaxYearId?: number;
        AccountAncestorAccountId?: number;
        AccountParentAccountId?: number;
        AccountCode?: string;
        AccountPlaceholder?: boolean;
        AccountTaxRelated?: boolean;
        AccountHidden?: boolean;
        AccountTypeId?: number;
        AccountTransactionAccountId?: number;
        AccountIsCollectorExpected?: boolean;
        AccountParallelAccountId?: number;
        AccountLayerId?: number;
        AccountIsPartnerExpected?: boolean;
        LanguageName?: string;
        LanguageIsActive?: boolean;
    }

    export namespace AccountNameRow {
        export const idProperty = 'AccountId';
        export const nameProperty = 'LanguageId';
        export const localTextPrefix = 'Cobrademo.AccountName';

        export namespace Fields {
            export declare const AccountId;
            export declare const LanguageId;
            export declare const Value;
            export declare const Note;
            export declare const AccountAvatarId: string;
            export declare const AccountTimestamp: string;
            export declare const AccountTreasuryAccountId: string;
            export declare const AccountTaxYearId: string;
            export declare const AccountAncestorAccountId: string;
            export declare const AccountParentAccountId: string;
            export declare const AccountCode: string;
            export declare const AccountPlaceholder: string;
            export declare const AccountTaxRelated: string;
            export declare const AccountHidden: string;
            export declare const AccountTypeId: string;
            export declare const AccountTransactionAccountId: string;
            export declare const AccountIsCollectorExpected: string;
            export declare const AccountParallelAccountId: string;
            export declare const AccountLayerId: string;
            export declare const AccountIsPartnerExpected: string;
            export declare const LanguageName: string;
            export declare const LanguageIsActive: string;
        }

        ['AccountId', 'LanguageId', 'Value', 'Note', 'AccountAvatarId', 'AccountTimestamp', 'AccountTreasuryAccountId', 'AccountTaxYearId', 'AccountAncestorAccountId', 'AccountParentAccountId', 'AccountCode', 'AccountPlaceholder', 'AccountTaxRelated', 'AccountHidden', 'AccountTypeId', 'AccountTransactionAccountId', 'AccountIsCollectorExpected', 'AccountParallelAccountId', 'AccountLayerId', 'AccountIsPartnerExpected', 'LanguageName', 'LanguageIsActive'].forEach(x => (<any>Fields)[x] = x);
    }
}

