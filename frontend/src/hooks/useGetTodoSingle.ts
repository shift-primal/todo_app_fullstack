import { api } from "@/lib/api";
import { useQuery } from "@tanstack/react-query";

export const useGetTodoSingle = (id: number) => {
	return useQuery({
		queryKey: ["todos"],
		queryFn: () => api.todos.getSingle(id)
	});
};
