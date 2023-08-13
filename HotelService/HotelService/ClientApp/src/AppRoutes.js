import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { Counter } from "./components/Counter";
import { CreateNewHouse } from './components/CreateNewHouse';
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/create-new-house',
    element: <CreateNewHouse/>
  },
  {
    path: '/fetch-data',
    requireAuth: true,
    element: <FetchData />
    },
  ...ApiAuthorzationRoutes
];

export default AppRoutes;
