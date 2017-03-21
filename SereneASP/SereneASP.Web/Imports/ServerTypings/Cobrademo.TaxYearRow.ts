﻿namespace SereneASP.Cobrademo {
    export interface TaxYearRow {
        Id?: number;
        Timestamp?: number[];
        ParentTaxYearId?: number;
        CurrencyId?: string;
        TaxCurrencyId?: string;
        Name?: string;
        YearNum?: number;
        StartDate?: string;
        EndDate?: string;
        VoucherFormat?: number;
        VoucherDigits?: number;
        VoucherSepFirst?: string;
        VoucherSepLast?: string;
        ReferenceNumFormat?: number;
        ReferenceNumDigits?: number;
        ReferenceNumSepFirst?: string;
        ReferenceNumSepLast?: string;
        IsClosed?: boolean;
        CurrencyEvaluationMode?: number;
        CurrencyExchangeType?: number;
        SalesExchanceType?: number;
        BookingExchangeType?: number;
        StockEvaluationMode?: number;
        FinanceLockDate?: string;
        ParallelBooking?: boolean;
        LedgerRounding?: boolean;
        SecondaryAccountAllowed?: boolean;
        BankTransactionBooking?: boolean;
        CashAccounting?: boolean;
        LedgerItemCollectorToSecondaryAccount?: boolean;
        LedgerRoundingThresholdAmount?: number;
        ApplyFinenceLockToStock?: boolean;
        CashAccountingVatCarryOver?: boolean;
        VatOffPeriodTransfer?: boolean;
        VatRateDifferenceTransfer?: boolean;
        VoucherShortYearNumber?: boolean;
        ReferenceShortYearNumber?: boolean;
        ParentTaxYearTimestamp?: number[];
        ParentTaxYearParentTaxYearId?: number;
        ParentTaxYearCurrencyId?: string;
        ParentTaxYearTaxCurrencyId?: string;
        ParentTaxYearName?: string;
        ParentTaxYearYearNum?: number;
        ParentTaxYearStartDate?: string;
        ParentTaxYearEndDate?: string;
        ParentTaxYearVoucherFormat?: number;
        ParentTaxYearVoucherDigits?: number;
        ParentTaxYearVoucherSepFirst?: string;
        ParentTaxYearVoucherSepLast?: string;
        ParentTaxYearReferenceNumFormat?: number;
        ParentTaxYearReferenceNumDigits?: number;
        ParentTaxYearReferenceNumSepFirst?: string;
        ParentTaxYearReferenceNumSepLast?: string;
        ParentTaxYearIsClosed?: boolean;
        ParentTaxYearCurrencyEvaluationMode?: number;
        ParentTaxYearCurrencyExchangeType?: number;
        ParentTaxYearSalesExchanceType?: number;
        ParentTaxYearBookingExchangeType?: number;
        ParentTaxYearStockEvaluationMode?: number;
        ParentTaxYearFinanceLockDate?: string;
        ParentTaxYearParallelBooking?: boolean;
        ParentTaxYearLedgerRounding?: boolean;
        ParentTaxYearSecondaryAccountAllowed?: boolean;
        ParentTaxYearBankTransactionBooking?: boolean;
        ParentTaxYearCashAccounting?: boolean;
        ParentTaxYearLedgerItemCollectorToSecondaryAccount?: boolean;
        ParentTaxYearLedgerRoundingThresholdAmount?: number;
        ParentTaxYearApplyFinenceLockToStock?: boolean;
        ParentTaxYearCashAccountingVatCarryOver?: boolean;
        ParentTaxYearVatOffPeriodTransfer?: boolean;
        ParentTaxYearVatRateDifferenceTransfer?: boolean;
        ParentTaxYearVoucherShortYearNumber?: boolean;
        ParentTaxYearReferenceShortYearNumber?: boolean;
        CurrencyName?: string;
        CurrencyIsActive?: boolean;
        CurrencyEndDate?: string;
        CurrencyMinAmount?: number;
        CurrencyTimestamp?: number[];
        CurrencyAvatarId?: number;
        TaxCurrencyName?: string;
        TaxCurrencyIsActive?: boolean;
        TaxCurrencyEndDate?: string;
        TaxCurrencyMinAmount?: number;
        TaxCurrencyTimestamp?: number[];
        TaxCurrencyAvatarId?: number;
    }

    export namespace TaxYearRow {
        export const idProperty = 'Id';
        export const nameProperty = 'CurrencyId';
        export const localTextPrefix = 'Cobrademo.TaxYear';

        export namespace Fields {
            export declare const Id: string;
            export declare const Timestamp: string;
            export declare const ParentTaxYearId: string;
            export declare const CurrencyId: string;
            export declare const TaxCurrencyId: string;
            export declare const Name: string;
            export declare const YearNum: string;
            export declare const StartDate: string;
            export declare const EndDate: string;
            export declare const VoucherFormat: string;
            export declare const VoucherDigits: string;
            export declare const VoucherSepFirst: string;
            export declare const VoucherSepLast: string;
            export declare const ReferenceNumFormat: string;
            export declare const ReferenceNumDigits: string;
            export declare const ReferenceNumSepFirst: string;
            export declare const ReferenceNumSepLast: string;
            export declare const IsClosed: string;
            export declare const CurrencyEvaluationMode: string;
            export declare const CurrencyExchangeType: string;
            export declare const SalesExchanceType: string;
            export declare const BookingExchangeType: string;
            export declare const StockEvaluationMode: string;
            export declare const FinanceLockDate: string;
            export declare const ParallelBooking: string;
            export declare const LedgerRounding: string;
            export declare const SecondaryAccountAllowed: string;
            export declare const BankTransactionBooking: string;
            export declare const CashAccounting: string;
            export declare const LedgerItemCollectorToSecondaryAccount: string;
            export declare const LedgerRoundingThresholdAmount: string;
            export declare const ApplyFinenceLockToStock: string;
            export declare const CashAccountingVatCarryOver: string;
            export declare const VatOffPeriodTransfer: string;
            export declare const VatRateDifferenceTransfer: string;
            export declare const VoucherShortYearNumber: string;
            export declare const ReferenceShortYearNumber: string;
            export declare const ParentTaxYearTimestamp: string;
            export declare const ParentTaxYearParentTaxYearId: string;
            export declare const ParentTaxYearCurrencyId: string;
            export declare const ParentTaxYearTaxCurrencyId: string;
            export declare const ParentTaxYearName: string;
            export declare const ParentTaxYearYearNum: string;
            export declare const ParentTaxYearStartDate: string;
            export declare const ParentTaxYearEndDate: string;
            export declare const ParentTaxYearVoucherFormat: string;
            export declare const ParentTaxYearVoucherDigits: string;
            export declare const ParentTaxYearVoucherSepFirst: string;
            export declare const ParentTaxYearVoucherSepLast: string;
            export declare const ParentTaxYearReferenceNumFormat: string;
            export declare const ParentTaxYearReferenceNumDigits: string;
            export declare const ParentTaxYearReferenceNumSepFirst: string;
            export declare const ParentTaxYearReferenceNumSepLast: string;
            export declare const ParentTaxYearIsClosed: string;
            export declare const ParentTaxYearCurrencyEvaluationMode: string;
            export declare const ParentTaxYearCurrencyExchangeType: string;
            export declare const ParentTaxYearSalesExchanceType: string;
            export declare const ParentTaxYearBookingExchangeType: string;
            export declare const ParentTaxYearStockEvaluationMode: string;
            export declare const ParentTaxYearFinanceLockDate: string;
            export declare const ParentTaxYearParallelBooking: string;
            export declare const ParentTaxYearLedgerRounding: string;
            export declare const ParentTaxYearSecondaryAccountAllowed: string;
            export declare const ParentTaxYearBankTransactionBooking: string;
            export declare const ParentTaxYearCashAccounting: string;
            export declare const ParentTaxYearLedgerItemCollectorToSecondaryAccount: string;
            export declare const ParentTaxYearLedgerRoundingThresholdAmount: string;
            export declare const ParentTaxYearApplyFinenceLockToStock: string;
            export declare const ParentTaxYearCashAccountingVatCarryOver: string;
            export declare const ParentTaxYearVatOffPeriodTransfer: string;
            export declare const ParentTaxYearVatRateDifferenceTransfer: string;
            export declare const ParentTaxYearVoucherShortYearNumber: string;
            export declare const ParentTaxYearReferenceShortYearNumber: string;
            export declare const CurrencyName: string;
            export declare const CurrencyIsActive: string;
            export declare const CurrencyEndDate: string;
            export declare const CurrencyMinAmount: string;
            export declare const CurrencyTimestamp: string;
            export declare const CurrencyAvatarId: string;
            export declare const TaxCurrencyName: string;
            export declare const TaxCurrencyIsActive: string;
            export declare const TaxCurrencyEndDate: string;
            export declare const TaxCurrencyMinAmount: string;
            export declare const TaxCurrencyTimestamp: string;
            export declare const TaxCurrencyAvatarId: string;
        }

        ['Id', 'Timestamp', 'ParentTaxYearId', 'CurrencyId', 'TaxCurrencyId', 'Name', 'YearNum', 'StartDate', 'EndDate', 'VoucherFormat', 'VoucherDigits', 'VoucherSepFirst', 'VoucherSepLast', 'ReferenceNumFormat', 'ReferenceNumDigits', 'ReferenceNumSepFirst', 'ReferenceNumSepLast', 'IsClosed', 'CurrencyEvaluationMode', 'CurrencyExchangeType', 'SalesExchanceType', 'BookingExchangeType', 'StockEvaluationMode', 'FinanceLockDate', 'ParallelBooking', 'LedgerRounding', 'SecondaryAccountAllowed', 'BankTransactionBooking', 'CashAccounting', 'LedgerItemCollectorToSecondaryAccount', 'LedgerRoundingThresholdAmount', 'ApplyFinenceLockToStock', 'CashAccountingVatCarryOver', 'VatOffPeriodTransfer', 'VatRateDifferenceTransfer', 'VoucherShortYearNumber', 'ReferenceShortYearNumber', 'ParentTaxYearTimestamp', 'ParentTaxYearParentTaxYearId', 'ParentTaxYearCurrencyId', 'ParentTaxYearTaxCurrencyId', 'ParentTaxYearName', 'ParentTaxYearYearNum', 'ParentTaxYearStartDate', 'ParentTaxYearEndDate', 'ParentTaxYearVoucherFormat', 'ParentTaxYearVoucherDigits', 'ParentTaxYearVoucherSepFirst', 'ParentTaxYearVoucherSepLast', 'ParentTaxYearReferenceNumFormat', 'ParentTaxYearReferenceNumDigits', 'ParentTaxYearReferenceNumSepFirst', 'ParentTaxYearReferenceNumSepLast', 'ParentTaxYearIsClosed', 'ParentTaxYearCurrencyEvaluationMode', 'ParentTaxYearCurrencyExchangeType', 'ParentTaxYearSalesExchanceType', 'ParentTaxYearBookingExchangeType', 'ParentTaxYearStockEvaluationMode', 'ParentTaxYearFinanceLockDate', 'ParentTaxYearParallelBooking', 'ParentTaxYearLedgerRounding', 'ParentTaxYearSecondaryAccountAllowed', 'ParentTaxYearBankTransactionBooking', 'ParentTaxYearCashAccounting', 'ParentTaxYearLedgerItemCollectorToSecondaryAccount', 'ParentTaxYearLedgerRoundingThresholdAmount', 'ParentTaxYearApplyFinenceLockToStock', 'ParentTaxYearCashAccountingVatCarryOver', 'ParentTaxYearVatOffPeriodTransfer', 'ParentTaxYearVatRateDifferenceTransfer', 'ParentTaxYearVoucherShortYearNumber', 'ParentTaxYearReferenceShortYearNumber', 'CurrencyName', 'CurrencyIsActive', 'CurrencyEndDate', 'CurrencyMinAmount', 'CurrencyTimestamp', 'CurrencyAvatarId', 'TaxCurrencyName', 'TaxCurrencyIsActive', 'TaxCurrencyEndDate', 'TaxCurrencyMinAmount', 'TaxCurrencyTimestamp', 'TaxCurrencyAvatarId'].forEach(x => (<any>Fields)[x] = x);
    }
}

