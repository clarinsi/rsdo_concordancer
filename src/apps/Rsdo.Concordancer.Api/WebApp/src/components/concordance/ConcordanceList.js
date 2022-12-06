import { useState } from 'react';
import ConcordanceListItem from './ConcordanceListItem';

const ConcordanceList = (props) => {
    const [expandedIndex, setExpandedIndex] = useState(null);

    return (
        <div>
            {props.items.map((x, i) => <ConcordanceListItem key={i} index={i} expanded={i === expandedIndex} item={x} toggleDetails={(index) => setExpandedIndex(index)} />)}
        </div>
    );
};

export default ConcordanceList;