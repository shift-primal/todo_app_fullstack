import { TodoPagination } from "@/components/TodoPagination";
import { useGetTodoAll } from "@/hooks/useGetTodoAll";
import { TodoPageParams, TodoQueryParams } from "@/types/types";
import { createFileRoute } from "@tanstack/react-router";
import { useState } from "react";
import { QueryControls } from "@/components/QueryControls";
import { TodoCard } from "@/components/TodoCard";

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
					<div id="main-section" className="p-4">
						<div className="w-3/4 h-fit flex flex-col gap-y-5 mx-auto">
							<QueryControls setQuery={setQuery} />
							{data.items.map((todo) => (
								<TodoCard key={todo.id} todo={todo} />
							))}
						</div>
					</div>
					<div
						id="pagination"
						className="absolute bottom-6 left-1/2 -translate-x-1/2"
					>
						<TodoPagination
							page={page}
							setPage={setPage}
							totalPages={data.totalPages as number}
						/>
					</div>
				</main>
			</>
		);
}
