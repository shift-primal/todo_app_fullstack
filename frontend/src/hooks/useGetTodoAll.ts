import { api } from "@/lib/api";
import { TodoPageParams, TodoQueryParams } from "@/types/types";
import { keepPreviousData, useQuery } from "@tanstack/react-query";

export const useGetTodoAll = ({
	query,
	page,
}: {
	query: TodoQueryParams;
	page: TodoPageParams;
}) => {
	return useQuery({
		queryKey: ["todos", query, page],
		queryFn: () => api.todos.getAll({ query, page }),
		placeholderData: keepPreviousData,
	});
};
