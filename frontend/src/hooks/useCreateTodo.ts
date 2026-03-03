import { api } from "@/lib/api";
import { CreateTodoRequest } from "@/types/types";
import { useMutation } from "@tanstack/react-query";

export const useCreateTodo = (req: CreateTodoRequest) => {
	return useMutation({
		mutationFn: () => api.todos.create(req)
	});
};
