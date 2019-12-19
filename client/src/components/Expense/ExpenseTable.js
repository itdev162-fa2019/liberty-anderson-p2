import React from 'react';
import ExpenseItem from './ExpenseItem';
import './styles.css';

const ExpenseTable = props => {
	const { expenses } = props;

	return(
		<table>
			<thead>
				<th>Date</th>
				<th>Category</th>
				<th>Amount</th>
			</thead>
			<tbody>
				{expenses.map(expense => <ExpenseItem key={expense.id} expense={expense}/>)}
			</tbody>
		</table>
	);
}

export default ExpenseTable;