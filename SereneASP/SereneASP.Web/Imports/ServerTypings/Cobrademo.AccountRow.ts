﻿
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
        LayerId?: number;
        IsPartnerExpected?: boolean;
        AvatarTableTypeId?: number;
        AvatarGlobalId?: string;
        TreasuryAccountNumber?: string;
        TreasuryAccountName?: string;
        TreasuryAccountTaxCode?: string;
        TreasuryAccountValidFrom?: string;
        TreasuryAccountValidUntil?: string;
        TaxYearTimestamp?: number[];
        TaxYearParentTaxYearId?: number;
        TaxYearCurrencyId?: string;
        TaxYearTaxCurrencyId?: string;
        TaxYearName?: string;
        TaxYearYearNum?: number;
        TaxYearStartDate?: string;
        TaxYearEndDate?: string;
        TaxYearVoucherFormat?: number;
        TaxYearVoucherDigits?: number;
        TaxYearVoucherSepFirst?: string;
        TaxYearVoucherSepLast?: string;
        TaxYearReferenceNumFormat?: number;
        TaxYearReferenceNumDigits?: number;
        TaxYearReferenceNumSepFirst?: string;
        TaxYearReferenceNumSepLast?: string;
        TaxYearIsClosed?: boolean;
        TaxYearCurrencyEvaluationMode?: number;
        TaxYearCurrencyExchangeType?: number;
        TaxYearSalesExchanceType?: number;
        TaxYearBookingExchangeType?: number;
        TaxYearStockEvaluationMode?: number;
        TaxYearFinanceLockDate?: string;
        TaxYearParallelBooking?: boolean;
        TaxYearLedgerRounding?: boolean;
        TaxYearSecondaryAccountAllowed?: boolean;
        TaxYearBankTransactionBooking?: boolean;
        TaxYearCashAccounting?: boolean;
        TaxYearLedgerItemCollectorToSecondaryAccount?: boolean;
        TaxYearLedgerRoundingThresholdAmount?: number;
        TaxYearApplyFinenceLockToStock?: boolean;
        TaxYearCashAccountingVatCarryOver?: boolean;
        TaxYearVatOffPeriodTransfer?: boolean;
        TaxYearVatRateDifferenceTransfer?: boolean;
        TaxYearVoucherShortYearNumber?: boolean;
        TaxYearReferenceShortYearNumber?: boolean;
        AncestorAccountAvatarId?: number;
        AncestorAccountTimestamp?: number[];
        AncestorAccountTreasuryAccountId?: number;
        AncestorAccountTaxYearId?: number;
        AncestorAccountAncestorAccountId?: number;
        AncestorAccountParentAccountId?: number;
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
        ParentAccountAvatarId?: number;
        ParentAccountTimestamp?: number[];
        ParentAccountTreasuryAccountId?: number;
        ParentAccountTaxYearId?: number;
        ParentAccountAncestorAccountId?: number;
        ParentAccountParentAccountId?: number;
        ParentAccountCode?: string;
        ParentAccountPlaceholder?: boolean;
        ParentAccountTaxRelated?: boolean;
        ParentAccountHidden?: boolean;
        ParentAccountTypeId?: number;
        ParentAccountTransactionAccountId?: number;
        ParentAccountIsCollectorExpected?: boolean;
        ParentAccountParallelAccountId?: number;
        ParentAccountLayerId?: number;
        ParentAccountIsPartnerExpected?: boolean;
        TransactionAccountAvatarId?: number;
        TransactionAccountTimestamp?: number[];
        TransactionAccountTreasuryAccountId?: number;
        TransactionAccountTaxYearId?: number;
        TransactionAccountAncestorAccountId?: number;
        TransactionAccountParentAccountId?: number;
        TransactionAccountCode?: string;
        TransactionAccountPlaceholder?: boolean;
        TransactionAccountTaxRelated?: boolean;
        TransactionAccountHidden?: boolean;
        TransactionAccountTypeId?: number;
        TransactionAccountTransactionAccountId?: number;
        TransactionAccountIsCollectorExpected?: boolean;
        TransactionAccountParallelAccountId?: number;
        TransactionAccountLayerId?: number;
        TransactionAccountIsPartnerExpected?: boolean;
        ParallelAccountAvatarId?: number;
        ParallelAccountTimestamp?: number[];
        ParallelAccountTreasuryAccountId?: number;
        ParallelAccountTaxYearId?: number;
        ParallelAccountAncestorAccountId?: number;
        ParallelAccountParentAccountId?: number;
        ParallelAccountCode?: string;
        ParallelAccountPlaceholder?: boolean;
        ParallelAccountTaxRelated?: boolean;
        ParallelAccountHidden?: boolean;
        ParallelAccountTypeId?: number;
        ParallelAccountTransactionAccountId?: number;
        ParallelAccountIsCollectorExpected?: boolean;
        ParallelAccountParallelAccountId?: number;
        ParallelAccountLayerId?: number;
        ParallelAccountIsPartnerExpected?: boolean;
    }

    export namespace AccountRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Code';
        export const localTextPrefix = 'Cobrademo.Account';

        export namespace Fields {
            export declare const Id;
            export declare const AvatarId;
            export declare const Timestamp;
            export declare const TreasuryAccountId;
            export declare const TaxYearId;
            export declare const AncestorAccountId;
            export declare const ParentAccountId;
            export declare const Code;
            export declare const Placeholder;
            export declare const TaxRelated;
            export declare const Hidden;
            export declare const TypeId;
            export declare const TransactionAccountId;
            export declare const IsCollectorExpected;
            export declare const ParallelAccountId;
            export declare const LayerId;
            export declare const IsPartnerExpected;
            export declare const AvatarTableTypeId: string;
            export declare const AvatarGlobalId: string;
            export declare const TreasuryAccountNumber: string;
            export declare const TreasuryAccountName: string;
            export declare const TreasuryAccountTaxCode: string;
            export declare const TreasuryAccountValidFrom: string;
            export declare const TreasuryAccountValidUntil: string;
            export declare const TaxYearTimestamp: string;
            export declare const TaxYearParentTaxYearId: string;
            export declare const TaxYearCurrencyId: string;
            export declare const TaxYearTaxCurrencyId: string;
            export declare const TaxYearName: string;
            export declare const TaxYearYearNum: string;
            export declare const TaxYearStartDate: string;
            export declare const TaxYearEndDate: string;
            export declare const TaxYearVoucherFormat: string;
            export declare const TaxYearVoucherDigits: string;
            export declare const TaxYearVoucherSepFirst: string;
            export declare const TaxYearVoucherSepLast: string;
            export declare const TaxYearReferenceNumFormat: string;
            export declare const TaxYearReferenceNumDigits: string;
            export declare const TaxYearReferenceNumSepFirst: string;
            export declare const TaxYearReferenceNumSepLast: string;
            export declare const TaxYearIsClosed: string;
            export declare const TaxYearCurrencyEvaluationMode: string;
            export declare const TaxYearCurrencyExchangeType: string;
            export declare const TaxYearSalesExchanceType: string;
            export declare const TaxYearBookingExchangeType: string;
            export declare const TaxYearStockEvaluationMode: string;
            export declare const TaxYearFinanceLockDate: string;
            export declare const TaxYearParallelBooking: string;
            export declare const TaxYearLedgerRounding: string;
            export declare const TaxYearSecondaryAccountAllowed: string;
            export declare const TaxYearBankTransactionBooking: string;
            export declare const TaxYearCashAccounting: string;
            export declare const TaxYearLedgerItemCollectorToSecondaryAccount: string;
            export declare const TaxYearLedgerRoundingThresholdAmount: string;
            export declare const TaxYearApplyFinenceLockToStock: string;
            export declare const TaxYearCashAccountingVatCarryOver: string;
            export declare const TaxYearVatOffPeriodTransfer: string;
            export declare const TaxYearVatRateDifferenceTransfer: string;
            export declare const TaxYearVoucherShortYearNumber: string;
            export declare const TaxYearReferenceShortYearNumber: string;
            export declare const AncestorAccountAvatarId: string;
            export declare const AncestorAccountTimestamp: string;
            export declare const AncestorAccountTreasuryAccountId: string;
            export declare const AncestorAccountTaxYearId: string;
            export declare const AncestorAccountAncestorAccountId: string;
            export declare const AncestorAccountParentAccountId: string;
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
            export declare const ParentAccountAvatarId: string;
            export declare const ParentAccountTimestamp: string;
            export declare const ParentAccountTreasuryAccountId: string;
            export declare const ParentAccountTaxYearId: string;
            export declare const ParentAccountAncestorAccountId: string;
            export declare const ParentAccountParentAccountId: string;
            export declare const ParentAccountCode: string;
            export declare const ParentAccountPlaceholder: string;
            export declare const ParentAccountTaxRelated: string;
            export declare const ParentAccountHidden: string;
            export declare const ParentAccountTypeId: string;
            export declare const ParentAccountTransactionAccountId: string;
            export declare const ParentAccountIsCollectorExpected: string;
            export declare const ParentAccountParallelAccountId: string;
            export declare const ParentAccountLayerId: string;
            export declare const ParentAccountIsPartnerExpected: string;
            export declare const TransactionAccountAvatarId: string;
            export declare const TransactionAccountTimestamp: string;
            export declare const TransactionAccountTreasuryAccountId: string;
            export declare const TransactionAccountTaxYearId: string;
            export declare const TransactionAccountAncestorAccountId: string;
            export declare const TransactionAccountParentAccountId: string;
            export declare const TransactionAccountCode: string;
            export declare const TransactionAccountPlaceholder: string;
            export declare const TransactionAccountTaxRelated: string;
            export declare const TransactionAccountHidden: string;
            export declare const TransactionAccountTypeId: string;
            export declare const TransactionAccountTransactionAccountId: string;
            export declare const TransactionAccountIsCollectorExpected: string;
            export declare const TransactionAccountParallelAccountId: string;
            export declare const TransactionAccountLayerId: string;
            export declare const TransactionAccountIsPartnerExpected: string;
            export declare const ParallelAccountAvatarId: string;
            export declare const ParallelAccountTimestamp: string;
            export declare const ParallelAccountTreasuryAccountId: string;
            export declare const ParallelAccountTaxYearId: string;
            export declare const ParallelAccountAncestorAccountId: string;
            export declare const ParallelAccountParentAccountId: string;
            export declare const ParallelAccountCode: string;
            export declare const ParallelAccountPlaceholder: string;
            export declare const ParallelAccountTaxRelated: string;
            export declare const ParallelAccountHidden: string;
            export declare const ParallelAccountTypeId: string;
            export declare const ParallelAccountTransactionAccountId: string;
            export declare const ParallelAccountIsCollectorExpected: string;
            export declare const ParallelAccountParallelAccountId: string;
            export declare const ParallelAccountLayerId: string;
            export declare const ParallelAccountIsPartnerExpected: string;
        }

        ['Id', 'AvatarId', 'Timestamp', 'TreasuryAccountId', 'TaxYearId', 'AncestorAccountId', 'ParentAccountId', 'Code', 'Placeholder', 'TaxRelated', 'Hidden', 'TypeId', 'TransactionAccountId', 'IsCollectorExpected', 'ParallelAccountId', 'LayerId', 'IsPartnerExpected', 'AvatarTableTypeId', 'AvatarGlobalId', 'TreasuryAccountNumber', 'TreasuryAccountName', 'TreasuryAccountTaxCode', 'TreasuryAccountValidFrom', 'TreasuryAccountValidUntil', 'TaxYearTimestamp', 'TaxYearParentTaxYearId', 'TaxYearCurrencyId', 'TaxYearTaxCurrencyId', 'TaxYearName', 'TaxYearYearNum', 'TaxYearStartDate', 'TaxYearEndDate', 'TaxYearVoucherFormat', 'TaxYearVoucherDigits', 'TaxYearVoucherSepFirst', 'TaxYearVoucherSepLast', 'TaxYearReferenceNumFormat', 'TaxYearReferenceNumDigits', 'TaxYearReferenceNumSepFirst', 'TaxYearReferenceNumSepLast', 'TaxYearIsClosed', 'TaxYearCurrencyEvaluationMode', 'TaxYearCurrencyExchangeType', 'TaxYearSalesExchanceType', 'TaxYearBookingExchangeType', 'TaxYearStockEvaluationMode', 'TaxYearFinanceLockDate', 'TaxYearParallelBooking', 'TaxYearLedgerRounding', 'TaxYearSecondaryAccountAllowed', 'TaxYearBankTransactionBooking', 'TaxYearCashAccounting', 'TaxYearLedgerItemCollectorToSecondaryAccount', 'TaxYearLedgerRoundingThresholdAmount', 'TaxYearApplyFinenceLockToStock', 'TaxYearCashAccountingVatCarryOver', 'TaxYearVatOffPeriodTransfer', 'TaxYearVatRateDifferenceTransfer', 'TaxYearVoucherShortYearNumber', 'TaxYearReferenceShortYearNumber', 'AncestorAccountAvatarId', 'AncestorAccountTimestamp', 'AncestorAccountTreasuryAccountId', 'AncestorAccountTaxYearId', 'AncestorAccountAncestorAccountId', 'AncestorAccountParentAccountId', 'AncestorAccountCode', 'AncestorAccountPlaceholder', 'AncestorAccountTaxRelated', 'AncestorAccountHidden', 'AncestorAccountTypeId', 'AncestorAccountTransactionAccountId', 'AncestorAccountIsCollectorExpected', 'AncestorAccountParallelAccountId', 'AncestorAccountLayerId', 'AncestorAccountIsPartnerExpected', 'ParentAccountAvatarId', 'ParentAccountTimestamp', 'ParentAccountTreasuryAccountId', 'ParentAccountTaxYearId', 'ParentAccountAncestorAccountId', 'ParentAccountParentAccountId', 'ParentAccountCode', 'ParentAccountPlaceholder', 'ParentAccountTaxRelated', 'ParentAccountHidden', 'ParentAccountTypeId', 'ParentAccountTransactionAccountId', 'ParentAccountIsCollectorExpected', 'ParentAccountParallelAccountId', 'ParentAccountLayerId', 'ParentAccountIsPartnerExpected', 'TransactionAccountAvatarId', 'TransactionAccountTimestamp', 'TransactionAccountTreasuryAccountId', 'TransactionAccountTaxYearId', 'TransactionAccountAncestorAccountId', 'TransactionAccountParentAccountId', 'TransactionAccountCode', 'TransactionAccountPlaceholder', 'TransactionAccountTaxRelated', 'TransactionAccountHidden', 'TransactionAccountTypeId', 'TransactionAccountTransactionAccountId', 'TransactionAccountIsCollectorExpected', 'TransactionAccountParallelAccountId', 'TransactionAccountLayerId', 'TransactionAccountIsPartnerExpected', 'ParallelAccountAvatarId', 'ParallelAccountTimestamp', 'ParallelAccountTreasuryAccountId', 'ParallelAccountTaxYearId', 'ParallelAccountAncestorAccountId', 'ParallelAccountParentAccountId', 'ParallelAccountCode', 'ParallelAccountPlaceholder', 'ParallelAccountTaxRelated', 'ParallelAccountHidden', 'ParallelAccountTypeId', 'ParallelAccountTransactionAccountId', 'ParallelAccountIsCollectorExpected', 'ParallelAccountParallelAccountId', 'ParallelAccountLayerId', 'ParallelAccountIsPartnerExpected'].forEach(x => (<any>Fields)[x] = x);
    }
}
