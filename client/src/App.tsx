import React from 'react';
import './App.css';
import axios from 'axios';

class App extends React.Component {
  state = {
    expenses: []
  }

  componentDidMount() {
    axios.get('http://localhost:5000/api/expenses')
    .then((response) => {
      this.setState({
        expenses: response.data
      })
    })
    .catch((error) => {
      console.error(`Error fetching data: ${error}`);
    })
  }

  render() {
		const { expenses } = this.state;

    return (
      <div className="App">
        <header className="App-header">
          Expense Monitor
        </header>
				<main>
					{expenses.map((expense: any) =>
						//the date is a hot mess- sqlite turned my datetime to a string for some reason
						<div key={expense.id}>
							<p>{expense.category}</p>
							<p>{new Intl.NumberFormat('en-US', {
								style: 'currency',
								currency: 'USD'
							}).format(expense.amount)}</p>
							<p>{new Intl.DateTimeFormat('en-US', {
								month: 'long',
								day: 'numeric',
								hour: 'numeric',
								minute: '2-digit'
							}).format(new Date(expense.date))}</p>
						</div>
					)}
				</main>
      </div>
    );
  }
}

export default App;
