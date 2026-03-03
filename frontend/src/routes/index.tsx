import { TodoList } from "@/components/TodoList";
import { useGetTodoAll } from "@/hooks/useGetTodoAll";
import { createFileRoute } from "@tanstack/react-router";

export const Route = createFileRoute("/")({ component: App });

function App() {
	const { data, isLoading, isError, isSuccess } = useGetTodoAll();

	if (isLoading) return <h1>Loading...</h1>;
	if (isError) return <h1>Error loading</h1>;

	console.log(data);

	if (isSuccess)
		return (
			<>
				<main>
					<TodoList data={data} />
				</main>
			</>
		);
}
