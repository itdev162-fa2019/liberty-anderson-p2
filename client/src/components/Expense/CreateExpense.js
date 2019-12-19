import React, { useState } from 'react';
import axios from 'axios';
import uuid from 'uuid';
import moment from 'moment';
import { useHistory } from 'react-router-dom';
import './styles.css';

const CreateExpense = ({ onExpenseCreated }) => {
	let history = useHistory();
	const [expenseData, setExpenseData] = useState({
		category: '',
		amount: ''
	});
	const { category, amount } = expenseData;

	const onChange = e => {
		const { name, value } = e.target;

		setExpenseData({
			...expenseData,
			[name]: value
		});
	};

	const create = async () => {
		if (!category || !amount) {
			console.log('Category and amount are required');
		} else {
			const newExpense = {
				id: uuid.v4(),
				category: category,
				amount: amount,
				date: moment().toISOString()
			};

			try {
				const config = {
					headers: {
						'Content-Type': 'application/json'
					}
				};

				const body = JSON.stringify(newExpense);
				const res = await axios.post(
					'http://localhost:5000/api/expenses',
					body,
					config
				);

				onExpenseCreated(res.data);
				history.push('/');
			} catch (error) {
				console.error(`Error creating expense: ${error.response.data}`);
			}
		}
	};

	return (
		<div className="form-container">
			<h2>Add Expense</h2>
			Category: <input
				name="category"
				type="text"
				value={category}
				onChange={e => onChange(e)}
			/>
			<br></br>
			Amount: 
			$<input
				name="amount"
				type="text"
				placeholder="00.00"
				value={amount}
				onChange={e => onChange(e)}
			/>
			<br></br>
			<button onClick={() => create()}>Record Expense</button>
		</div>
	);
};

export default CreateExpense;