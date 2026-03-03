import { api } from "@/lib/api";
import { useMutation } from "@tanstack/react-query";

export const useDeleteTodo = (id: number) => {
	return useMutation({
		mutationFn: () => api.todos.delete(id)
	});
};
