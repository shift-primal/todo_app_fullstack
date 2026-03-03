import { api } from "@/lib/api";
import { UpdateTodoRequest } from "@/types/types";
import { useMutation } from "@tanstack/react-query";

export const useUpdateTodo = (id: number, req: UpdateTodoRequest) => {
	return useMutation({
		mutationFn: () => api.todos.update(id, req)
	});
};
