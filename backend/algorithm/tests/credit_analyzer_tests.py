from credit_analyzer import credit_analyzer as ca


def test_age_risk_getter():
    assert ca.get_age_risk(2023) == 5, 'Should be 5'
    assert ca.get_age_risk(1998) == 1, 'Should be 1'
    assert ca.get_age_risk(1989) == 1, 'Should be 1'
    assert ca.get_age_risk(1968) == 3, 'Should be 3'
    assert ca.get_age_risk(1930) == 10, 'Should be 10'
    print('Age getter tests passed')


def test_bank_account_risk():
    assert ca.get_bank_accounts_risk('Да') == 1, 'Should be 1'
    assert ca.get_bank_accounts_risk('Нет') == 5, 'Should be 5'
    print('Bank account risk test passed')


def test_salaru_risk():
    assert ca.get_salary_risk(45000) == 15, 'Should be 15'
    assert ca.get_salary_risk(50000) == 7, 'Should be 7'
    print('Salary risk tests passed')


def run_all_tests():
    test_age_risk_getter()
    test_bank_account_risk()