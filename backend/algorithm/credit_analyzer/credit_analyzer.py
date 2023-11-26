from datetime import date


def parse_data(data: list) -> list:
    '''
    Преобразует исходную строку данных клиента в обрабатываемый формат
    '''
    data[1] = int(data[1][6:]) # Год рождения
    try: # Стаж работы
        data[8] = int(data[8][:2]) # 10 лет и более
    except ValueError:
        data[8] = int(data[8][:1]) # До 10 лет

    data[10] = int(float(data[10])) # Подтвержденный оснв. доход
    try:
        data[12] = int(float(data[12])) # Подтвержденный доп. доход
    except ValueError:
        data[12] = 0 # Дохода нет

    return data


def get_risk_points(data: list, credit_rate: str, dli: float) -> int:
    risk_level_table = {
        'Семейное положение': {
            'Холост': 3,
            'Женат/замужем': 2,
            'Женат': 2,
            'Замужем': 2,
            'В разводе': 5
        },
        'Наличие детей':
        {
            'Да': 3,
            'Нет': 5
        },
        'Кредитная история':
        {
            'Хорошая': 1,
            'Средняя': 8,
            'Плохая': 15,
            'Отсутствует': 3
        }
    }
    risk_level = 0
    
    risk_level += get_age_risk(data[1])
    risk_level += risk_level_table['Семейное положение'][data[5]]
    risk_level += risk_level_table['Наличие детей'][data[6]]

    risk_level += risk_level_table['Кредитная история'][credit_rate]

    risk_level += get_work_experience_risk(data[8])

    risk_level += get_dli_risk(dli)

    if data[13] == 'Нет':
        risk_level += get_salary_risk(data[10])
    else:
        risk_level += get_salary_risk(data[10] + data[12])

    risk_level += get_bank_accounts_risk(data[15])

    return risk_level


def get_risk_level(points: int) -> str:
    if points <= 30:
        return 'Низкий'
    elif 30 < points <= 70:
        return 'Средний'
    else:
        return 'Высокий'


def get_dli_risk(dli: float) -> int:
    if dli < 0.70:
        return 1
    elif 0.70 <= dli < 0.95:
        return 10
    else:
        return 20


def get_age_risk(year: int) -> int:
    age = date.today().year - year
    if age < 25:
        return 5
    elif 25 <= age < 55:
        return 1
    elif 55 <= age < 74:
        return 3
    else:
        return 10
    

def get_salary_risk(salary: int) -> int:
    salary = salary // 1000
    if salary < 50:
        return 15
    elif 50 <= salary <= 100:
        return 7
    elif 100 < salary <= 250:
        return 5
    else:
        return 3
    

def get_work_experience_risk(time: int) -> int:
    if time < 1:
        return 10
    elif 1 <= time < 5:
        return 3
    else:
        return 2
    

def get_bank_accounts_risk(info: str) -> int:
    return 1 if info == 'Да' else 5