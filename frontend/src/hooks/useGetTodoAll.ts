import { api } from "@/lib/api";
import { TodoQuery } from "@/types/types";
import { useQuery } from "@tanstack/react-query";

export const useGetTodoAll = (params?: TodoQuery) => {
	return useQuery({
		queryKey: ["todos", params],
		queryFn: () => api.todos.getAll(params)
	});
};
