import React from 'react';
import axios from 'axios';
import { BrowserRouter as Router, Switch, Route, Link } from 'react-router-dom';
import ExpenseTable from './components/Expense/ExpenseTable';
import CreateExpense from './components/Expense/CreateExpense';
import './App.css';

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
	
	onExpenseCreated = expense => {
		const newExpenses = [...this.state.expenses, expense];

		this.setState({
			expenses: newExpenses
		});
	};

  render() {
		const { expenses } = this.state;

    return (
			<Router>
				<div className="App">
					<header className="App-header">Expense Monitor</header>
					<nav>
						<Link to="/">Home</Link>
						<Link to="/new-expense">Add Expense</Link>
					</nav>
					<main className="App-content">
						<Switch>
							<Route exact path="/">
								<ExpenseTable expenses={expenses}/>
							</Route>
							<Route path="/new-expense">
								<CreateExpense onExpenseCreated={this.onExpenseCreated} />
							</Route>
						</Switch>
					</main>
				</div>
			</Router>
    );
  }
}

export default App;
