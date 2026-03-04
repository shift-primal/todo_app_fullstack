import {
	CreateTodoRequest,
	PagedResult,
	TodoItemType,
	TodoPageParams,
	TodoQueryParams,
	UpdateTodoRequest,
} from "@/types/types";
import axios from "axios";

const client = axios.create({
	baseURL: import.meta.env.VITE_API_BASE_URL,
	headers: { "Content-Type": "application/json" },
});

export const api = {
	todos: {
		getAll: ({
			query,
			page,
		}: {
			query: TodoQueryParams;
			page: TodoPageParams;
		}) =>
			client
				.get<PagedResult>("/todos", { params: { ...query, ...page } })
				.then((r) => r.data),
		getSingle: (id: number) =>
			client.get<TodoItemType>(`/todos/${id}`).then((r) => r.data),
		create: (body: CreateTodoRequest) => client.post("/todos", body),
		update: (id: number, body: UpdateTodoRequest) =>
			client.put(`/todos/${id}`, body),
		delete: (id: number) => client.delete(`/todos/${id}`),
	},
};
