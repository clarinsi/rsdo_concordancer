import { Routes, Route } from 'react-router-dom';
import {
  QueryClient,
  QueryClientProvider
} from 'react-query'
import ConcordanceIndex from './pages/concordance/ConcordanceIndex';
import ConcordanceResults from './pages/concordance/ConcordanceResults';
import ListIndex from './pages/list/ListIndex';
import ListResults from './pages/list/ListResults';
import NoCorpus from './pages/NoCorpus';

function App() {
  const queryClient = new QueryClient();
  return (
    <QueryClientProvider client={queryClient}>
      <Routes>
        <Route path='/:corpusId/concordance' element={<ConcordanceIndex />} />
        <Route path='/:corpusId/concordance/search' element={<ConcordanceResults />} />
        <Route path='/:corpusId/list' element={<ListIndex />} />
        <Route path='/:corpusId/list/search' element={<ListResults />} />
        <Route path='/:corpusId/*' element={<ConcordanceIndex />} />
        <Route path='*' element={<NoCorpus />} />
      </Routes>
    </QueryClientProvider>
  );
}

export default App;
