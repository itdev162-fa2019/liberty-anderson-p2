import React from 'react';

const ExpenseItem = props => {
	const { expense } = props;

	return (
		<tr>
			<td>{new Intl.DateTimeFormat('en-US', {
				month: 'long',
				day: 'numeric',
				hour: 'numeric',
				minute: '2-digit'
			}).format(new Date(expense.date))}</td>
			<td>{expense.category}</td>
			<td>{new Intl.NumberFormat('en-US', {
				style: 'currency',
				currency: 'USD'
			}).format(expense.amount)}</td>
		</tr>
	)
}

export default ExpenseItem;