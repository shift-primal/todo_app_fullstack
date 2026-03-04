import { TodoPagination } from "@/components/TodoPagination";
import { TodoList } from "@/components/TodoList";
import { useGetTodoAll } from "@/hooks/useGetTodoAll";
import { TodoPageParams, TodoQueryParams } from "@/types/types";
import { createFileRoute } from "@tanstack/react-router";
import { useState } from "react";

export const Route = createFileRoute("/")({ component: App });

function App() {
	const [query, setQuery] = useState<TodoQueryParams>({});
	const [page, setPage] = useState<TodoPageParams>({
		PageNumber: 1,
		PageSize: 10,
	});

	const { data, isLoading, isError, isSuccess } = useGetTodoAll({
		query,
		page,
	});

	if (isLoading) return <h1>Loading...</h1>;
	if (isError) return <h1>Error loading</h1>;

	if (isSuccess)
		return (
			<>
				<main>
					<div className="grid rows-2 gap-y-16">
						<div
							id="main-section"
							className="row-span-1 items-self-center"
						>
							<TodoList data={data.items} />
						</div>
						<div id="pagination" className="row-span-1">
							<TodoPagination page={page} setPage={setPage} totalPages={data.totalPages as number} />
						</div>
					</div>
				</main>
			</>
		);
}
