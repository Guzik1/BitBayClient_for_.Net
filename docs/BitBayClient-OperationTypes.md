#### [BitBayClient](./index.md 'index')
### [BitBayClient](./BitBayClient.md 'BitBayClient')
## OperationTypes Enum
Types of operation enum.  
```csharp
public enum OperationTypes
```
### Fields
<a name='BitBayClient-OperationTypes-CREATE_BALANCE'></a>
`CREATE_BALANCE` 0  
Create balance.  
  
<a name='BitBayClient-OperationTypes-ADD_FUNDS'></a>
`ADD_FUNDS` 1  
Add funds to balance.  
  
<a name='BitBayClient-OperationTypes-SUBTRACT_FUNDS'></a>
`SUBTRACT_FUNDS` 2  
Withdraw funds from balance.  
  
<a name='BitBayClient-OperationTypes-TRANSFER_FROM'></a>
`TRANSFER_FROM` 3  
Transfer from balance.  
  
<a name='BitBayClient-OperationTypes-TRANSFER_TO'></a>
`TRANSFER_TO` 4  
Transfer to balance.  
  
<a name='BitBayClient-OperationTypes-TRANSACTION_COMMISSION_OUTCOME'></a>
`TRANSACTION_COMMISSION_OUTCOME` 5  
Pay transaction commision.  
  
<a name='BitBayClient-OperationTypes-TRANSACTION_PRE_LOCKING'></a>
`TRANSACTION_PRE_LOCKING` 6  
Locked funds on balance.  
  
<a name='BitBayClient-OperationTypes-LOCK_FUNDS'></a>
`LOCK_FUNDS` 7  
Locked funds on balance.  
  
<a name='BitBayClient-OperationTypes-ADMIN_LOCK_FUNDS'></a>
`ADMIN_LOCK_FUNDS` 8  
Administrator was locked funds on balance.  
  
<a name='BitBayClient-OperationTypes-UNLOCK_FUNDS'></a>
`UNLOCK_FUNDS` 9  
Unlock funds on balance.  
  
<a name='BitBayClient-OperationTypes-ADMIN_UNLOCK_FUNDS'></a>
`ADMIN_UNLOCK_FUNDS` 10  
Administrator was unlock funds on balance.  
  
<a name='BitBayClient-OperationTypes-TRANSACTION_POST_INCOME'></a>
`TRANSACTION_POST_INCOME` 11  
Get funds from transaction to balance.  
  
<a name='BitBayClient-OperationTypes-TRANSACTION_POST_OUTCOME'></a>
`TRANSACTION_POST_OUTCOME` 12  
Pay funds from transaction from balance.  
  
<a name='BitBayClient-OperationTypes-ADMIN_ADD_FUNDS'></a>
`ADMIN_ADD_FUNDS` 13  
Administrator correct (add) funds on balance.  
  
<a name='BitBayClient-OperationTypes-ADMIN_SUBTRACT_FUNDS'></a>
`ADMIN_SUBTRACT_FUNDS` 14  
Administrator correct (substract) funds on balance.  
  
<a name='BitBayClient-OperationTypes-TRANSACTION_OFFER_ABORTED_RETURN'></a>
`TRANSACTION_OFFER_ABORTED_RETURN` 15  
Return funds for delete offer to balance.  
  
<a name='BitBayClient-OperationTypes-AFFILIATE_FUNDS_TRANSFER'></a>
`AFFILIATE_FUNDS_TRANSFER` 16  
Affilate funds from partner program.  
  
<a name='BitBayClient-OperationTypes-PAY_WITHDRAW_LOCK'></a>
`PAY_WITHDRAW_LOCK` 17  
Locked funds on balance.  
  
<a name='BitBayClient-OperationTypes-TRANSACTION_OFFER_COMPLETED_RETURN'></a>
`TRANSACTION_OFFER_COMPLETED_RETURN` 18  
Cancellation of offer bellow minimum value.  
  
<a name='BitBayClient-OperationTypes-TRANSACTION_FAIL_UNLOCKING'></a>
`TRANSACTION_FAIL_UNLOCKING` 19  
Return funds after unsuccessful add offer.  
  
<a name='BitBayClient-OperationTypes-WITHDRAWAL_LOCK_FUNDS'></a>
`WITHDRAWAL_LOCK_FUNDS` 20  
Lock funds.  
  
<a name='BitBayClient-OperationTypes-WITHDRAWAL_UNLOCK_FUNDS'></a>
`WITHDRAWAL_UNLOCK_FUNDS` 21  
Unlock funds.  
  
<a name='BitBayClient-OperationTypes-WITHDRAWAL_SUBTRACT_FUNDS'></a>
`WITHDRAWAL_SUBTRACT_FUNDS` 22  
Withdraw funds.  
  
<a name='BitBayClient-OperationTypes-FUNDS_MIGRATION'></a>
`FUNDS_MIGRATION` 23  
Migration funds.  
  
<a name='BitBayClient-OperationTypes-TRANSACTION_COMMISSION_RETURN'></a>
`TRANSACTION_COMMISSION_RETURN` 24  
Return transaction commision to balance.  
  
<a name='BitBayClient-OperationTypes-ADD_FUNDS_ERROR_REFUND'></a>
`ADD_FUNDS_ERROR_REFUND` 25  
Lock correction.  
  
<a name='BitBayClient-OperationTypes-OLD_ADDRESS_CRYPTO_DEPOSIT'></a>
`OLD_ADDRESS_CRYPTO_DEPOSIT` 26  
Deposit on constant addres.  
  
<a name='BitBayClient-OperationTypes-FIAT_DEPOSIT_MIGRATED'></a>
`FIAT_DEPOSIT_MIGRATED` 27  
Real currency deposit on balance.  
  
<a name='BitBayClient-OperationTypes-ADMIN_WITHDRAWAL_REFUND'></a>
`ADMIN_WITHDRAWAL_REFUND` 28  
Return funds for canceked withdraw by administrator.  
  
<a name='BitBayClient-OperationTypes-SUBTRACT_FUNDS_ERROR_CORRECTION'></a>
`SUBTRACT_FUNDS_ERROR_CORRECTION` 29  
Funds correction.  
  
<a name='BitBayClient-OperationTypes-ADD_FUNDS_COMPENSATION'></a>
`ADD_FUNDS_COMPENSATION` 30  
Recompense.  
  
<a name='BitBayClient-OperationTypes-BITCOIN_GOLD_FORK'></a>
`BITCOIN_GOLD_FORK` 31  
Bitcoin gold fork.  
  
<a name='BitBayClient-OperationTypes-BALANCE_DEPOSIT_CORRECTION'></a>
`BALANCE_DEPOSIT_CORRECTION` 32  
Deposit correction.  
  
<a name='BitBayClient-OperationTypes-WITHDRAWAL_CUSTOM_COMMISSION'></a>
`WITHDRAWAL_CUSTOM_COMMISSION` 33  
Commission for Bitcoin network..  
  
