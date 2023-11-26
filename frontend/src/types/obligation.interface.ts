export interface IObligation {
  id: number; // идентификатор обязательства
  type: string; // вид обязательства
  startDate: string; // дата открытия
  endDate: string; // дата планового закрытия
  actualEndDate: string; // дата фактического закрытия
  role: string; // роль (заемщик, поручитель, созаемщик)
  status: string; // статус (текущий, завершенный)
  amount: number; // сумма
  interestRate: number; // % ставка
  balance: number; // остаток к выплате
  overdueDays: number; // просрочка в днях
  overdueAmount: number; // сумма просрочки
  reportId: number; // идентификатор отчета
}
