import { Button } from "@/components/ui/button";
import { Calendar } from "@/components/ui/calendar";
import { Field } from "@/components/ui/field";
import {
	Popover,
	PopoverContent,
	PopoverTrigger,
} from "@/components/ui/popover";
import { TodoQueryParams } from "@/types/types";
import { format } from "date-fns";
import { CalendarIcon, RotateCcw } from "lucide-react";
import { Dispatch, SetStateAction, useState } from "react";
import { type DateRange } from "react-day-picker";

export function DatePickerWithRange({
	setQuery,
}: {
	setQuery: Dispatch<SetStateAction<TodoQueryParams>>;
}) {
	const [date, setDate] = useState<DateRange | undefined>();

	const handleSelect = (range: DateRange | undefined) => {
		setDate(range);
		setQuery((q) => ({
			...q,
			From: range?.from?.toISOString(),
			To: range?.to?.toISOString(),
		}));
	};

	const handleReset = () => {
		setDate(undefined);
		setQuery((q) => ({
			...q,
			From: undefined,
			To: undefined,
		}));
	};

	return (
		<>
			<Field className="w-60">
				<Popover>
					<PopoverTrigger asChild>
						<Button
							variant="outline"
							id="date-picker-range"
							className="justify-start px-2.5 font-normal relative cursor-pointer"
						>
							<CalendarIcon />
							{date?.from ? (
								date.to ? (
									<>
										{format(date.from, "LLL dd, y")} -{" "}
										{format(date.to, "LLL dd, y")}
									</>
								) : (
									format(date.from, "LLL dd, y")
								)
							) : (
								<span>Pick a date</span>
							)}
						</Button>
					</PopoverTrigger>
					<PopoverContent className="w-auto p-0" align="start">
						<Calendar
							mode="range"
							defaultMonth={date?.from}
							selected={date}
							onSelect={handleSelect}
							numberOfMonths={2}
						/>
					</PopoverContent>
				</Popover>
			</Field>
			<Button
				variant="destructive"
				className="cursor-pointer"
				onClick={handleReset}
			>
				{<RotateCcw />}
			</Button>
		</>
	);
}
