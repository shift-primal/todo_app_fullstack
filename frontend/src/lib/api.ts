import {
	CreateTodoRequest,
	TodoItemType,
	TodoQuery,
	UpdateTodoRequest,
} from "@/types/types";
import axios from "axios";

const client = axios.create({
	baseURL: import.meta.env.VITE_API_BASE_URL,
	headers: { "Content-Type": "application/json" },
});

export const api = {
	todos: {
		getAll: (params?: TodoQuery) =>
			client
				.get<TodoItemType[]>("/todos", { params })
				.then((r) => r.data),
		getSingle: (id: number) =>
			client.get<TodoItemType>(`/todos/${id}`).then((r) => r.data),
		create: (body: CreateTodoRequest) => client.post("/todos", body),
		update: (id: number, body: UpdateTodoRequest) =>
			client.put(`/todos/${id}`, body),
		delete: (id: number) => client.delete(`/todos/${id}`),
	},
};
