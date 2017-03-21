namespace SereneASP.Cobrademo {
    export interface AccountRow {
        Id?: number;
        AvatarId?: number;
        Timestamp?: number[];
        TreasuryAccountId?: number;
        TaxYearId?: number;
        AncestorAccountId?: number;
        ParentAccountId?: number;
        Code?: string;
        Placeholder?: boolean;
        TaxRelated?: boolean;
        Hidden?: boolean;
        TypeId?: number;
        TransactionAccountId?: number;
        IsCollectorExpected?: boolean;
        ParallelAccountId?: number;
        LayerId?: Modules.Cobrademo.Account.LayerEnum;
        IsPartnerExpected?: boolean;
        AvatarTableTypeId?: number;
        AvatarGlobalId?: string;
        TreasuryAccountNumber?: string;
        TreasuryAccountName?: string;
        TreasuryAccountTaxCode?: string;
        TreasuryAccountValidFrom?: string;
        TreasuryAccountValidUntil?: string;
        TaxYearName?: string;
        TaxYearYearNum?: number;
        AncestorAccountCode?: string;
        AncestorAccountPlaceholder?: boolean;
        AncestorAccountTaxRelated?: boolean;
        AncestorAccountHidden?: boolean;
        AncestorAccountTypeId?: number;
        AncestorAccountTransactionAccountId?: number;
        AncestorAccountIsCollectorExpected?: boolean;
        AncestorAccountParallelAccountId?: number;
        AncestorAccountLayerId?: number;
        AncestorAccountIsPartnerExpected?: boolean;
        ParentAccountCode?: string;
        TransactionAccountCode?: string;
        ParallelAccountCode?: string;
    }

    export namespace AccountRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Cobrademo.Account';

        export namespace Fields {
            export declare const Id: string;
            export declare const AvatarId: string;
            export declare const Timestamp: string;
            export declare const TreasuryAccountId: string;
            export declare const TaxYearId: string;
            export declare const AncestorAccountId: string;
            export declare const ParentAccountId: string;
            export declare const Code: string;
            export declare const Placeholder: string;
            export declare const TaxRelated: string;
            export declare const Hidden: string;
            export declare const TypeId: string;
            export declare const TransactionAccountId: string;
            export declare const IsCollectorExpected: string;
            export declare const ParallelAccountId: string;
            export declare const LayerId: string;
            export declare const IsPartnerExpected: string;
            export declare const AvatarTableTypeId: string;
            export declare const AvatarGlobalId: string;
            export declare const TreasuryAccountNumber: string;
            export declare const TreasuryAccountName: string;
            export declare const TreasuryAccountTaxCode: string;
            export declare const TreasuryAccountValidFrom: string;
            export declare const TreasuryAccountValidUntil: string;
            export declare const TaxYearName: string;
            export declare const TaxYearYearNum: string;
            export declare const AncestorAccountCode: string;
            export declare const AncestorAccountPlaceholder: string;
            export declare const AncestorAccountTaxRelated: string;
            export declare const AncestorAccountHidden: string;
            export declare const AncestorAccountTypeId: string;
            export declare const AncestorAccountTransactionAccountId: string;
            export declare const AncestorAccountIsCollectorExpected: string;
            export declare const AncestorAccountParallelAccountId: string;
            export declare const AncestorAccountLayerId: string;
            export declare const AncestorAccountIsPartnerExpected: string;
            export declare const ParentAccountCode: string;
            export declare const TransactionAccountCode: string;
            export declare const ParallelAccountCode: string;
        }

        ['Id', 'AvatarId', 'Timestamp', 'TreasuryAccountId', 'TaxYearId', 'AncestorAccountId', 'ParentAccountId', 'Code', 'Placeholder', 'TaxRelated', 'Hidden', 'TypeId', 'TransactionAccountId', 'IsCollectorExpected', 'ParallelAccountId', 'LayerId', 'IsPartnerExpected', 'AvatarTableTypeId', 'AvatarGlobalId', 'TreasuryAccountNumber', 'TreasuryAccountName', 'TreasuryAccountTaxCode', 'TreasuryAccountValidFrom', 'TreasuryAccountValidUntil', 'TaxYearName', 'TaxYearYearNum', 'AncestorAccountCode', 'AncestorAccountPlaceholder', 'AncestorAccountTaxRelated', 'AncestorAccountHidden', 'AncestorAccountTypeId', 'AncestorAccountTransactionAccountId', 'AncestorAccountIsCollectorExpected', 'AncestorAccountParallelAccountId', 'AncestorAccountLayerId', 'AncestorAccountIsPartnerExpected', 'ParentAccountCode', 'TransactionAccountCode', 'ParallelAccountCode'].forEach(x => (<any>Fields)[x] = x);
    }
}

