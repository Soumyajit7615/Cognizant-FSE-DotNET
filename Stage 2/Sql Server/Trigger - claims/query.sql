CREATE TRIGGER claims_audits
ON dbo.claims
FOR INSERT
AS
    DECLARE @customer_name VARCHAR(30)
    DECLARE @amount_of_claim VARCHAR(25)
    
    
    SELECT @customer_name = ( 
                                SELECT cust.first_name
                                FROM customer cust
                                JOIN customer_policy policy
                                ON cust.id = policy.customer_id
                                JOIN claims claim
                                ON policy.id = claim.customer_policy_id, inserted i
                                WHERE claim.id = i.id
                            )
    SELECT @amount_of_claim = (
                                SELECT claim.amount_of_claim + i.amount_of_claim + 50000
                                FROM inserted i ,claims claim
                                JOIN customer_policy policy
                                ON claim.customer_policy_id = policy.id
                                WHERE i.id = claim.id
                            )
    
    INSERT into dbo.claim_audit(customer_name, amount_of_claim,action)
    SELECT @customer_name,@amount_of_claim,'Updated customer claimed amount';

GO
